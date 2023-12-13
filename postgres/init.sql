CREATE USER jwt_user WITH PASSWORD 'jwt_password' CREATEDB;
CREATE SCHEMA jwt AUTHORIZATION jwt_user;

ALTER USER jwt_user SET search_path TO jwt;

DROP TABLE IF EXISTS public.appuser;
CREATE TABLE IF NOT EXISTS public."appuser"(
      ID SERIal PRIMARY KEY     NOT NULL,
      NAME           TEXT    NOT NULL,
      AGE            INT     NOT NULL,
      ADDRESS        CHAR(50),
      SALARY         REAL );
INSERT INTO public.appuser (NAME,AGE,ADDRESS,SALARY)
VALUES ( 'Paul', 32, 'California', 20000.00 );
INSERT INTO public.appuser (NAME,AGE,ADDRESS,SALARY)
VALUES ( 'Allen', 25, 'Texas', 15000.00 );
INSERT INTO public.appuser (NAME,AGE,ADDRESS,SALARY)
VALUES ( 'Teddy', 23, 'Norway', 20000.00 );
INSERT INTO public.appuser (NAME,AGE,ADDRESS,SALARY)
VALUES ( 'Mark', 25, 'Rich-Mond ', 65000.00 );