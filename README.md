# IntegrationStore_APP

IntegrationStore_APP es una aplicación de escritorio diseñada para la gestión de compra, venta y control de inventario de manera eficiente.

## Funcionalidades

1. **Gestión de Inventario**
   - Permite registrar compras y actualizar automáticamente el inventario.
   - Descuenta stock al realizar ventas y muestra alertas cuando hay bajo inventario.

2. **Usuarios**
   - CRUD para gestionar personal, vendedores y administrativos.

3. **Mantenedor**
   - CRUD para proveedores.
   - Edición de roles y permisos.
   - Cambio de logo empresarial.

4. **Reportes y Exportaciones**
   - Generación de boletas en formato PDF.
   - Exportación de informes en Excel.

## Requisitos
- **Visual Studio** (versión 2019 o superior).
- **.NET Framework**.
- **SQL Server** (para almacenamiento de datos).

## Cómo usar

1. Clonar este repositorio:
   ```bash
   git clone https://github.com/Reload-ARTS/IntegrationStore_APP.git
   ```
2. Abrir el proyecto en **Visual Studio**.
3. Configurar la base de datos en SQL Server y ajustar la cadena de conexión.
4. Compilar y ejecutar la aplicación.

## Integraciones Técnicas
- **SQL Server**: Base de datos para el almacenamiento y gestión de productos, usuarios y proveedores.
- **.NET Framework**: Desarrollo de la aplicación en C#.
- **Office Interop**: Exportación de informes en Excel.
- **iTextSharp**: Generación de boletas en PDF.

## Mejoras Futuras
- Implementación de API para acceso remoto.
- Optimización de la interfaz gráfica.
- Integración de un sistema de roles y permisos más detallado.

## Autor
Desarrollado por **Antonio Toro Sagredo**.

