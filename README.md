# SQL_Formatter

C# SQL statement formatter class  

## Example
<pre>
update a set a.ID = b.ID, Name = b.Name from Table1 a 
inner join (select ID, Name from Table2 where Active <> 0 and Current <> 0)  b 
on a.ownerid = b.ownerid and a.type = b.type and b.version = '87.1' 
and a.Name is Null where a.expired <> 0
</pre>

becomes

<pre>
update a 
set a.ID = b.ID,
	Name = b.Name 
from Table1 a 
	inner join 
	(
	select ID,
		Name 
	from Table2 
	where Active <> 0 
		and Current <> 0
	) b on a.ownerid = b.ownerid and a.type = b.type and b.version = '87.1' and a.Name is NULL 
where a.expired <> 0
</pre>

## The source
The solution includes a simple winforms demo executable along with the Formatter class.  The implementation of the formatter employs a number of routines from unrelated libraried code; I've pulled these fragments into an additional file: LIB.cs.


