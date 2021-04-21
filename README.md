# TicketsMNG

1. Restaurar la base de datos creada en SQL server que se encuentra en /backup

2. En el archivo appsettings.json se encuentra la cadena de conexion la cual se debe editar de acuerdo a su configuracion local
    - Data Source=[Servidor]\\[Instancia];Initial Catalog=[base de datos];User ID=[usuario];Password=[Password]
    
3. el proyecto esta configurado para iniciar como https://[localhots]:[puerto]/api/tickets

4. a continuacion se relacionan las busquedas en postman

  -Get busqueda general https://localhost:44368/api/Tickets
  
  -Get busqueda filtrada https://localhost:44368/api/Tickets/[Id de ticket a editar]
  
  arroja un arreglo con todos los registro creados en la tabla
  
  - Post https://localhost:44368/api/Tickets 
  consulta Json
  
  {
        "user": "Armando.medina",
        "createdon": "2021-04-20",
        "Modifiedon": "2021-04-20",
        "Status": "Cerrado"
}

-PuT https://localhost:44368/api/Tickets/[Id de ticket a editar]
{
    "id": 1,
        "user": "Armando.medina.nieto",
        "createdon": "2021-04-20",
        "Status": "Cerrado"
}

- Delete https://localhost:44368/api/Tickets/[Id de ticket a editar]
