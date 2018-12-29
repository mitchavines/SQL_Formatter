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

## Feedback
I'd be very interested in thoughts regarding the approach... is there a better, more formal method I'm missing?

I've tested this solution against a sample of 500+ statements, but these were all written by just a few developers so the test cases may be less diverse than hoped.  Also, the intention is to support any SQL dialect but there is currently a significant bias towards T-SQL.

Any thoughts regarding defects, changes required to support other dialects, support for formatting options, etc. would be much appreciated.

