Create database Bookdb

use Bookdb
------------

CREATE TABLE books (
    [isbn]      char(13)  primary key,
    [title]     VARCHAR (MAX) NOT NULL,
    [author]    VARCHAR (MAX) NOT NULL,
    [publisher] VARCHAR (MAX) NOT NULL,
    [year]      CHAR (4)      NOT NULL
);

insert into books values(2553768512963,'Two States','Chetan Bhagat','Rupa Publications',2009);
insert into books values(6238567483546,'The Alchemist','Paulo Coelho','Harper Collins',1988);
insert into books values(8694595407963,'11 Hours','Daniel Paul Singh','Write India Publishers',2017);

select *from books;
