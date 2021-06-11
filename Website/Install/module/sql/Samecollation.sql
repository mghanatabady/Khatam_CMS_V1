select 'alter table [' + s.name + '].[' + t.name + '] alter column [' + c.name + '] ' +
                ty.name + case when ty.name not in ('text', 'sysname') then '(' + case when c.max_length > 0 then
                case when ty.name not in ('nchar', 'nvarchar') then convert(varchar, c.max_length) else convert(varchar, c.max_length/2) end else 'max' end +

                ')' else '' end + ' collate SQL_Latin1_General_CP1_CI_AS ' +
                case when c.is_nullable = 0 then 'NOT ' else '' end + 'NULL'
from (sys.columns c inner join sys.types ty on c.system_type_id = ty.system_type_id) inner join
                (sys.objects t inner join sys.schemas s on t.schema_id = s.schema_id) on c.object_id = t.object_id
where t.type='U' and c.collation_name is not null and ty.name <> 'sysname'
order by s.name, t.name, c.column_id
