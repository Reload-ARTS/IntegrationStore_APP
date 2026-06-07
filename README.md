# Integration Store

Sistema de gestión de inventario, compras y ventas desarrollado en **C#**, **Windows Forms** y **SQL Server**, orientado a pequeñas y medianas empresas que requieren administrar productos, clientes, proveedores y transacciones comerciales desde una única plataforma.

---

## Descripción

Integration Store fue desarrollado como proyecto académico para la carrera de Analista Programador durante el año 2024.

La aplicación permite gestionar el ciclo completo de operación de una tienda informática, incluyendo control de inventario, registro de compras, registro de ventas, administración de clientes y proveedores, generación de reportes y exportación de información.

---

## Características Principales

### Gestión de Usuarios

* Administración de usuarios.
* Control de acceso mediante roles.
* Activación y desactivación de cuentas.

### Gestión de Inventario

* Administración de categorías.
* Registro y actualización de productos.
* Control de stock.
* Gestión de precios de compra y venta.

### Gestión Comercial

* Registro de clientes.
* Registro de proveedores.
* Registro de compras.
* Registro de ventas.

### Reportes

* Reporte de compras.
* Reporte de ventas.
* Filtros por fecha.
* Exportación a Excel.

### Documentación

* Generación de comprobantes PDF para compras.
* Generación de comprobantes PDF para ventas.

### Integridad de Datos

* Restricción de eliminación de registros asociados a transacciones históricas.
* Actualización automática de stock después de compras y ventas.

---

## Tecnologías Utilizadas

* C#
* Windows Forms
* SQL Server
* ADO.NET
* Arquitectura Multicapa
* Exportación a Excel
* Generación de PDF

---

## Arquitectura del Proyecto

El sistema fue desarrollado utilizando una arquitectura multicapa:

```text
PresentationLayer
│
├── BusinessLayer
│
├── DataLayer
│
└── EntityLayer
```

### Capas

**PresentationLayer**

* Formularios Windows Forms.
* Interacción con el usuario.

**BusinessLayer**

* Reglas de negocio.
* Validaciones.

**DataLayer**

* Acceso a datos.
* Consultas SQL.

**EntityLayer**

* Entidades y modelos de datos.

---

## Base de Datos

Motor utilizado:

* SQL Server

Script de creación:

```text
DBSystemApp.sql
```

El script incluye la estructura principal de tablas, relaciones y datos necesarios para la ejecución del sistema.

---

## Capturas del Sistema

### Login

![Login](docs/screenshots/01%20-%20login.png)

### Menú Principal

![Interfaz](docs/screenshots/02%20-%20interfaz.png)

### Gestión de Usuarios

![Usuarios](docs/screenshots/03%20-%20usuarios.png)

### Gestión de Categorías

![Categorias](docs/screenshots/04%20-%20categoria.png)

### Gestión de Productos

![Productos](docs/screenshots/05%20-%20productos.png)

### Exportación Excel de Productos

![Excel Productos](docs/screenshots/06%20-%20excel_productos.png)

### Configuración del Negocio

![Negocio](docs/screenshots/07%20-%20negocio.png)

### Registro de Ventas

![Venta](docs/screenshots/08%20-%20registrar_venta.png)

### Detalle de Venta

![Detalle Venta](docs/screenshots/09%20-%20detalle_venta.png)

### PDF de Venta

![PDF Venta](docs/screenshots/10%20-%20pdf_detalle_venta.png)

### Registro de Compras

![Compra](docs/screenshots/11%20-%20registro_compra.png)

### Detalle de Compra

![Detalle Compra](docs/screenshots/12%20-%20detalle_compra.png)

### PDF de Compra

![PDF Compra](docs/screenshots/13%20-%20pdf_detalle_compra.png)

### Clientes

![Clientes](docs/screenshots/14%20-%20clientes.png)

### Proveedores

![Proveedores](docs/screenshots/15%20-%20proveedores.png)

### Reporte de Compras

![Reporte Compras](docs/screenshots/16%20-%20reporte_compra.png)

### Exportación Excel de Compras

![Excel Compras](docs/screenshots/17%20-%20excel_compra.png)

### Reporte de Ventas

![Reporte Ventas](docs/screenshots/18%20-%20reporte_ventas.png)

### Exportación Excel de Ventas

![Excel Ventas](docs/screenshots/19%20-%20excel_venta.png)

### Acerca del Proyecto

![Acerca De](docs/screenshots/20%20-%20acerca_de.png)

---

## Instalación

### Requisitos

* Windows
* SQL Server
* Visual Studio

### Pasos

1. Restaurar la base de datos utilizando el script `DBSystemApp.sql`.
2. Configurar la cadena de conexión en `App.config`.
3. Abrir la solución `IntegrationStore_APP.sln`.
4. Compilar y ejecutar el proyecto.

---

## Credenciales Demo

Administrador:

Documento:

```text
178945-3
```

Contraseña:

```text
Admin2024
```

Empleado:

Documento:

```text
195874-8
```

Contraseña:

```text
Venta2024
```

---

## Estado del Proyecto

Proyecto finalizado y conservado como parte del portafolio personal para demostrar conocimientos en:

* Programación orientada a objetos.
* Desarrollo de aplicaciones de escritorio.
* SQL Server.
* Arquitectura multicapa.
* Gestión de inventario.
* Desarrollo de sistemas administrativos.

---

## Autor

Antonio Toro Sagredo

Analista Programador
