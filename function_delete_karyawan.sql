CREATE OR REPLACE FUNCTION tb_delete(_id character)
returns int AS
'
BEGIN
	DELETE FROM public.karyawan
	WHERE id_karyawan = _id;
	IF FOUND THEN
		return 1;
	ELSE
		return 0;
	END IF;
END
'
language plpgsql;