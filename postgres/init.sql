CREATE USER jwt_user WITH PASSWORD 'jwt_password' CREATEDB;
CREATE SCHEMA jwt AUTHORIZATION jwt_user;