-- Table: public.products

-- DROP TABLE IF EXISTS public.products;

CREATE TABLE IF NOT EXISTS public.products
(
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    name character varying(30) COLLATE pg_catalog."default",
    price integer,
    storage_id integer,
    CONSTRAINT "Products_pkey" PRIMARY KEY (id),
    CONSTRAINT prdct_ref_strg_fk FOREIGN KEY (id)
        REFERENCES public.storages (id) MATCH SIMPLE
        ON UPDATE RESTRICT
        ON DELETE RESTRICT
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.products
    OWNER to postgres;