BEGIN;


CREATE TABLE IF NOT EXISTS public.departemen
(
    id_dep integer NOT NULL,
    nama_dep character varying(30) NOT NULL,
    PRIMARY KEY (id_dep)
);

CREATE TABLE IF NOT EXISTS public.karyawan
(
    id_karyawan character(6) NOT NULL,
    nama character varying(30) NOT NULL,
    id_dep integer NOT NULL,
    PRIMARY KEY (id_karyawan)
);

ALTER TABLE IF EXISTS public.karyawan
    ADD FOREIGN KEY (id_dep)
    REFERENCES public.departemen (id_dep) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION
    NOT VALID;

END;