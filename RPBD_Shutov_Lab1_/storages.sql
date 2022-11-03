-- Table: public.storages

-- DROP TABLE IF EXISTS public.storages;

CREATE TABLE IF NOT EXISTS public.storages
(
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    name character varying(30) COLLATE pg_catalog."default",
    address character varying(50) COLLATE pg_catalog."default",
    CONSTRAINT "Storages_pkey" PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.storages
    OWNER to postgres;