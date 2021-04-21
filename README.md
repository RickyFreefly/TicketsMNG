# TicketsMNG

1. Restaurar la base de datos creada en SQL server que se encuentra en /backup

2. En el archivo appsettings.json se encuentra la cadena de conexion la cual se debe editar de acuerdo a su configuracion local
    - Data Source=[Servidor]\\[Instancia];Initial Catalog=[base de datos];User ID=[usuario];Password=[Password]
    
3. El proyecto esta configurado para iniciar como https://[localhots]:[puerto]/api/tickets

4. A continuación se relacionan las busquedas en postman

BUSQUEDA GENERAL
  -Get busqueda general https://localhost:44368/api/Tickets
  
BUSQUEDA ESPECIFICA  
  -Get busqueda filtrada https://localhost:44368/api/Tickets/[Id de ticket]
  
CREACION DE REGISTRO
  
  - Post https://localhost:44368/api/Tickets 
  consulta Json
  
  {
        "user": "Armando.medina",
        "createdon": "2021-04-20",
        "Modifiedon": "2021-04-20",
        "Status": "Cerrado"
}

EDICION DE REGISTRO

-PuT https://localhost:44368/api/Tickets/[Id de ticket a editar]
{
    "id": 1,
        "user": "Armando.medina.nieto",
        "createdon": "2021-04-20",
        "Status": "Cerrado"
}

ELIMINACION DE REGISTRO

- Delete https://localhost:44368/api/Tickets/[Id de ticket a editar]
