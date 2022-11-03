using System.Data;
using Microsoft.Data.SqlClient;
using Npgsql;
using System.Data.SQLite;
using System.Text.Json;

namespace RPBD_Shutov_Lab1_
{
    public partial class Form1 : Form
    {
        private IDbConnection _actualConnection;

        private class ConnectionConfig
        {
            private string _stringConnection;
            private string _name;
            public override string ToString() => _name;
            public string getConnection() => _stringConnection;
            public ConnectionConfig(string name, string stringConnection)
            {
                _name = name;
                _stringConnection = stringConnection;
            }
        }

        private const string _confJSON = "appsettings.json";
        private const string _products = "Products";
        private const string _storages = "Storages";
        private List<ConnectionConfig> _configs = new List<ConnectionConfig>();
        private ConnectionConfig _actualConfig;
        public Form1()
        {
            JsonElement obj = JsonSerializer.Deserialize<JsonElement>(File.ReadAllText(_confJSON));
            JsonElement.ObjectEnumerator objs = obj.EnumerateObject();
            foreach (var item in objs)
            {
                string name = item.Name;
                string conn;
                try
                {
                    conn = item.Value.GetProperty("connection").GetString();
                } 
                catch (Exception ex)
                {
                    throw new JsonException("Unable read connection string from JSON file: { \"DBMS\": {\"connection\": \"{string_connection}\" } } ", ex);
                }
                _configs.Add(new ConnectionConfig(name, conn));
            }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbTypes.Items.AddRange(_configs.ToArray());
        }

        private void SetupPanel(ConnectionConfig cf)
        {
            string _conStr = cf.getConnection();
                
            _actualConnection?.Close();
            _actualConnection = GetConnection(_conStr);
            _actualConnection.Open();

            SelectFrom(_products, Enumerable.Empty<KeyValuePair<string, object>>());
            SelectFrom(_storages, Enumerable.Empty<KeyValuePair<string, object>>());
        }

        private void SelectFrom(string tableName, IEnumerable<KeyValuePair<string, object>> preds)
        {
            IDbCommand cmd;
            var parameters = new List<IDbDataParameter>();

            string query = $"SELECT * FROM {tableName}";
            if (preds != null && preds.Any())
            {
                query += " WHERE " +
                    string.Join(" AND ", preds.Select(val =>
                    {
                        string valQ = $"{val.Key.ToUpper()}";
                        parameters.Add(GetParam(valQ, val.Value));
                        
                        return $"{val.Key} = @{valQ}";
                    })) + ";";
            }

            cmd = GetCommand(query);
            parameters.ForEach(x => cmd.Parameters.Add(x));
            
            DataSet ds = new DataSet();
            var adapter = GetAdapter(cmd);
            adapter.Fill(ds);
            var listBox = tableName == _products ? productsListBox : storagesListBox;
            listBox.DataSource = ds.Tables[0];
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";
        }

        private void AddRow(string tableName)
        {
            string query;
            var insertions = new List<string>();
            var parameters = new List<IDbDataParameter>();
            if (tableName == _products)
            {
                if (id1.Text != "")
                {
                    insertions.Add("id");
                    parameters.Add(GetParam("ID", int.Parse(id1.Text)));
                }
                if (name1.Text != "")
                {
                    insertions.Add("name");
                    parameters.Add(GetParam("NAME", name1.Text));
                }
                if (price1.Text != "")
                {
                    insertions.Add("price");
                    parameters.Add(GetParam("PRICE", int.Parse(price1.Text)));
                }
                if (storage_id1.Text != "")
                {
                    insertions.Add("storage_id");
                    parameters.Add(GetParam("STORAGE_ID", int.Parse(storage_id1.Text)));
                }
            }
            else
            {
                if (id2.Text != "")
                {
                    insertions.Add("id");
                    parameters.Add(GetParam("ID", int.Parse(id2.Text)));
                }
                if (name2.Text != "")
                {
                    insertions.Add("name");
                    parameters.Add(GetParam("NAME", name2.Text));
                }
                if (address2.Text != "")
                {
                    insertions.Add("address");
                    parameters.Add(GetParam("ADDRESS", address2.Text));
                }
            }
            query = $"INSERT INTO {tableName}({string.Join(", ", insertions)}) VALUES ({string.Join(", ", parameters.Select(x => '@' + x.ParameterName))})";
            var cmd = GetCommand(query);
            parameters.ForEach(p => cmd.Parameters.Add(p));
            cmd.ExecuteNonQuery();
        }

        private void DeleteRow(string tableName)
        {
            var listBox = tableName == _products ? productsListBox : storagesListBox;
            string query = $"DELETE FROM {tableName} WHERE Id={(listBox.SelectedItem as DataRowView).Row["Id"]}";
            var cmd = GetCommand(query);
            cmd.ExecuteNonQuery();
        }

        private void EditRow(string tableName)
        {
            string query;
            var insertions = new List<string>();
            var parameters = new List<IDbDataParameter>();
            DataRowView current;
            if (tableName == _products)
            {
                current = productsListBox.SelectedItem as DataRowView;
                if (id1.Text != "")
                {
                    insertions.Add("id");
                    parameters.Add(GetParam("ID", int.Parse(id1.Text)));
                }
                if (name1.Text != "")
                {
                    insertions.Add("name");
                    parameters.Add(GetParam("NAME", name1.Text));
                }
                if (price1.Text != "")
                {
                    insertions.Add("price");
                    parameters.Add(GetParam("PRICE", int.Parse(price1.Text)));
                }
                if (storage_id1.Text != "")
                {
                    insertions.Add("storage_id");
                    parameters.Add(GetParam("STORAGE_ID", int.Parse(storage_id1.Text)));
                }
            }
            else
            {
                current = storagesListBox.SelectedItem as DataRowView;
                if (id2.Text != "")
                {
                    insertions.Add("id");
                    parameters.Add(GetParam("ID", int.Parse(id2.Text)));
                }
                if (name2.Text != "")
                {
                    insertions.Add("name");
                    parameters.Add(GetParam("NAME", name2.Text));
                }
                if (address2.Text != "")
                {
                    insertions.Add("address");
                    parameters.Add(GetParam("ADDRESS", address2.Text));
                }
            }

            query = $"UPDATE {tableName} " +
                $"SET {string.Join(", ", insertions.Zip(parameters, (first, second) => $"{first} = @{second.ParameterName}"))}" +
                $" WHERE id = {current.Row["Id"]}";
            var cmd = GetCommand(query);
            parameters.ForEach(p => cmd.Parameters.Add(p));
            cmd.ExecuteNonQuery();
        }

        private void FilterSelect(string tableName)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            if (tableName == _products)
            {
                if (id1.Text != "")
                {
                    parameters.Add(new KeyValuePair<string, object>("id", int.Parse(id1.Text)));
                }
                if (name1.Text != "")
                {
                    parameters.Add(new KeyValuePair<string, object>("name", name1.Text));
                }
                if (price1.Text != "")
                {
                    parameters.Add(new KeyValuePair<string, object>("price", int.Parse(price1.Text)));
                }
                if (storage_id1.Text != "")
                {
                    parameters.Add(new KeyValuePair<string, object>("storage_id", int.Parse(storage_id1.Text)));
                }
            }
            else
            {
                if (id2.Text != "")
                {
                    parameters.Add(new KeyValuePair<string, object>("id", int.Parse(id2.Text)));
                }
                if (name2.Text != "")
                {
                    parameters.Add(new KeyValuePair<string, object>("name", name2.Text));
                }
                if (address2.Text != "")
                {
                    parameters.Add(new KeyValuePair<string, object>("address", address2.Text));
                }
            }
            SelectFrom(tableName, parameters);
        }

        private IDbDataParameter GetParam(string name, object value)
        {
            return _actualConfig.ToString() switch
            {
                "PostgreSQL" => new NpgsqlParameter(name, value),
                "SQLite" => new SQLiteParameter(name, value),
                "SQL Server" => new SqlParameter(name, value),
            };
        }

        private IDbCommand GetCommand(string query)
        {
            return _actualConfig.ToString() switch
            {
                "PostgreSQL" => new NpgsqlCommand(query, _actualConnection as NpgsqlConnection),
                "SQLite" => new SQLiteCommand(query, _actualConnection as SQLiteConnection),
                "SQL Server" => new SqlCommand(query, _actualConnection as SqlConnection),
            };
        }

        private IDbConnection GetConnection(string connStr)
        {
            string dbmsName = _actualConfig.ToString();
            try
            {
                return dbmsName switch
                {
                    "PostgreSQL" => new NpgsqlConnection(connStr),
                    "SQLite" => new SQLiteConnection(connStr),
                    "SQL Server" => new SqlConnection(connStr),
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Unable connect to {dbmsName}.", ex);
            }
        }

        private IDataAdapter GetAdapter(IDbCommand cmd)
        {
            return _actualConfig.ToString() switch
            {
                "PostgreSQL" => new NpgsqlDataAdapter(cmd as NpgsqlCommand),
                "SQLite" => new SQLiteDataAdapter(cmd as SQLiteCommand),
                "SQL Server" => new SqlDataAdapter(cmd as SqlCommand),
            };
        }

        private void connect_Click(object sender, EventArgs e)
        {
            var selectedDB = dbTypes.SelectedItem;

            if (selectedDB == null)
                return;

            _actualConfig = (ConnectionConfig)selectedDB;
            if (_actualConfig.ToString() != "SQLite")
                procButton.Visible = true;
            else
                procButton.Visible = false;
            SetupPanel(_actualConfig);
        }

        private void productsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (sender as ListBox).SelectedItem as DataRowView;
            name1.Text = item.Row["Name"].ToString();
            price1.Text = item.Row["Price"].ToString();
            id1.Text = item.Row["Id"].ToString();
            storage_id1.Text = item.Row["Storage_id"].ToString();
        }

        private void storagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (sender as ListBox).SelectedItem as DataRowView;
            id2.Text = item.Row["Id"].ToString();
            name2.Text = item.Row["Name"].ToString();
            address2.Text = item.Row["Address"].ToString();
        }

        private void del2_Click(object sender, EventArgs e)
        {
            DeleteRow(_storages);
        }

        private void del1_Click(object sender, EventArgs e)
        {
            DeleteRow(_products);
        }

        private void add1_Click(object sender, EventArgs e)
        {
            AddRow(_products);
        }

        private void add2_Click(object sender, EventArgs e)
        {
            AddRow(_storages);
        }

        private void refresh1_Click(object sender, EventArgs e)
        {
            SelectFrom(_products, Enumerable.Empty<KeyValuePair<string, object>>());
        }

        private void refresh2_Click(object sender, EventArgs e)
        {
            SelectFrom(_storages, Enumerable.Empty<KeyValuePair<string, object>>());
        }

        private void edit1_Click(object sender, EventArgs e)
        {
            EditRow(_products);
        }

        private void edit2_Click(object sender, EventArgs e)
        {
            EditRow(_storages);
        }

        private void filter1_Click(object sender, EventArgs e)
        {
            FilterSelect(_products);
        }

        private void filter2_Click(object sender, EventArgs e)
        {
            FilterSelect(_storages);
        }

        private void procButton_Click(object sender, EventArgs e)
        {
            var query = $"CALL create_own_storage('{name1.Text}', {price1.Text});";
            var cmd = GetCommand(query);
            cmd.ExecuteNonQuery();
        }
    }
}