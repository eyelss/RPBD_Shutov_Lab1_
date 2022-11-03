CREATE OR REPLACE PROCEDURE 
public.create_own_storage(
  _name varchar(30), 
  _price integer
)
LANGUAGE plpgsql
AS $$
DECLARE
	_own_id INTEGER;
BEGIN
	INSERT INTO storages(name, address)
	VALUES (_name || '_storage', 'base')
	RETURNING id INTO _own_id;

	INSERT INTO products(name, price, storage_id)
	VALUES (_name, _price, _own_id);
END
$$;