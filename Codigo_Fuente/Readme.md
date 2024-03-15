# Pasos para la configuracion de la Api.

## Creación de la Base de Datos ##

Ejecucion de los scripts de la carpeta - **Scripts_BD**, en el siguiente orden con el usuario **master** o similar con los permisos necesarios:

1. Ejecutar el script con nombre **01_ScriptCreateStructure**, para crear la base de datos con su estructura de datos del proyecto.

##### Configuracion archivo appsettings:

1. **ConnectionStrings** - Configuracion de la cadena de conexion de base de datos.
- **DefaultConnection:** Se debe cambiar su valor actual por la configuracion del servidor de base de datos, ejemplo:
'Server=```{Servidor base de datos}```;Initial Catalog=```{Nombre base de datos}```;Persist Security Info=False;User ID=```{Usuario servidor base de datos}```;Password=```{Contraseña servidor base de datos}```;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=```{Timeout para consultas a base de datos}```'
