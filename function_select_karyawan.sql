drop function tb_select();
create or replace function tb_select()
returns table
(
    id_karyawan character,
    nama character varying,
    nama_departemen character varying
)
language plpgsql
as
'
BEGIN
    return query
    SELECT k.id_karyawan, k.nama, d.nama_dep FROM public.karyawan k JOIN public.departemen d ON k.id_dep = d.id_dep;
END
'
