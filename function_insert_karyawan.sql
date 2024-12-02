create or replace function tb_insert
(
	_id_karyawan character,
	_nama character varying,
	_id_dep integer
)
returns int AS
'
BEGIN
	INSERT INTO public.karyawan(id_karyawan, nama, id_dep)
	VALUES
	(
		_id_karyawan,
		_nama,
		_id_dep
	);
	IF FOUND THEN
		return 1;
	ELSE
		return 0;
	END IF;
END
'
language plpgsql;