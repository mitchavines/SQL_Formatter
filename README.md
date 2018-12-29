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

## Overview

It turns out that parsing a SQL statement for formatting can be tricky; comments and dynamic SQL especially so.  

At one point I thought to simplify things by removing comments and quoted values entirely, restoring them after formatting was complete.

Of course it doesn't work like that.  An apostrophe preceded by -- is part of a comment, but -- preceded by an apostrophe is a literal value... there's nothing like operator precedence to help, and no getting around parsing from beginning to end.

I had also expected that formatting would be a recursive operation, but that idea foundered on identifying the end of a statement.

So, the concept is nothing more than reading from start to end and keeping track of context along the way.

This implementation uses two passes: first to remove any existing formatting, and then to apply the desired formatting; and instead of working through the statement one character at a time, we grab white-space delimited elements and go from there.

It's not clear to me how comments can be addressed in any helpful way and they generally require cleanup in the formatted result.

## The source
The solution includes a simple winforms demo executable along with the Formatter class.  The implementation of the formatter employs a number of routines from unrelated libraried code; I've pulled these fragments into an additional file: LIB.cs.

## Feedback
I learned a fair bit getting this implementation to its current state and I'm sharing it here hoping it might prove useful to others--but also to solicit comments on the approach.  Is there a better, more formal method I'm missing?

I've informally tested this solution against a sample of 500+ statements, but these were all written by just a few developers so the test cases may be less diverse than the number might suggest.  Also, the intention is to support any SQL dialect but there is a significant bias towards T-SQL.  

Any thoughts regarding defects, changes required to support other dialects, support for formatting options, etc. are much appreciated.

Thanks!
