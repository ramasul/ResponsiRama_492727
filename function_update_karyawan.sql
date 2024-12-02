create or replace function karyawan_update
(
	_id character,
 	_name character varying,
	_id_dep integer
)
	returns int
	AS
'
BEGIN
	UPDATE public.karyawan SET
		nama = _name,
		id_dep = _id_dep
	WHERE id_karyawan = _id;
	IF FOUND THEN
		return 1;
	ELSE
		return 0;
	END IF;
END
'
language plpgsql;