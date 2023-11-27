


CREATE USER jwt WITH ENCRIPTED PASSWORD 'jwt_password' CREATEDB;
GRANT CREATE ON DATABASE my_database TO jwt;

# ALTER ROLE|USER role_name SET search_path TO schema_name;

ALTER USER jwt_user SET search_path TO jwt;


dotnet ef migrations add FirstMigration -o Models/Migrations --context MyApi.Models.Jwt.JwtContext

dotnet ef database update  --context MyApi.Models.Jwt.JwtContext
