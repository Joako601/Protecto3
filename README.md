# 📊 Proyecto Jo' - Sistema de Gestión Financiera y Operativa

![Status](https://img.shields.io/badge/Status-Desarrollo%20Activo-green)
![Framework](https://img.shields.io/badge/.NET-10.0-blue)
![Architecture](https://img.shields.io/badge/Architecture-MVC-orange)
![Focus](https://img.shields.io/badge/Focus-Business%20Intelligence-success)

**Proyecto Jo'** es una solución integral diseñada para proporcionar visibilidad operativa y control financiero estratégico, sumado a que
el sistema centraliza el flujo de trabajo diario de una organización, permitiendo a dueños y administradores monitorear la salud económica del negocio mediante una gestión eficiente de recursos y
datos en tiempo real.

## 🎯 Propuesta de Valor

El software está diseñado para transformar la operativa diaria en datos accionables, permitiendo:
* **Control Centralizado**: Un flujo de trabajo unificado para la gestión financiera.
* **Toma de Decisiones**: Visibilidad total de métricas clave para la administración de activos.
* **Escalabilidad**: Arquitectura modular preparada para el crecimiento del volumen de operaciones.

## 🏗️ Entidades del Dominio

El núcleo del sistema orquestra las siguientes entidades de negocio fundamentales:

* **Usuarios**: Control de acceso, seguridad y gestión de perfiles administrativos.
* **Pedidos**: Ciclo de vida completo de las transacciones comerciales.
* **Productos**: Catálogo técnico y gestión de atributos de mercancía.
* **Cliente**: Registro y seguimiento de relaciones comerciales (CRM).
* **Inventario**: Monitoreo de existencias, control de mermas y auditoría de stock.
* **Punto de Venta (POS)**: Interfaz operativa para la ejecución de ventas y flujos de caja.
* **Proveedor**: Gestión de cadena de suministro y obligaciones financieras.
* **Métricas**: Motor de análisis para reportes de rendimiento y salud financiera.

## 🛠️ Stack Tecnológico

* **Backend**: ASP.NET Core MVC (.NET 8.0/9.0)
* **Lenguaje**: C#
* **Frontend**: Razor Pages, CSS3 (Estructura modular)
* **Documentación**: ADRs (Architecture Decision Records) para trazabilidad técnica.

## 📂 Estructura del Proyecto

```
├── ADRs/                # Architecture Decision Records
├── Controllers/         # Lógica de orquestación y flujo de datos
├── Models/              # Definición del dominio y entidades de negocio
├── Views/               # Componentes de interfaz de usuario (Razor)
├── wwwroot/             # Activos estáticos y recursos globales (CSS, JS)
├── ProyectoJo.slnx      # Definición de la solución de Visual Studio
└── appsettings.json     # Configuración de entornos y variables
```

## 🏛️ Decisiones de Arquitectura (ADR)

Para garantizar la mantenibilidad y escalabilidad del sistema, cada decisión estructural crítica se documenta en la carpeta /ADRs.
Esto permite una trazabilidad completa del diseño del sistema, facilitando auditorías técnicas y la integración de nuevos desarrolladores al flujo de trabajo de ingeniería.

## 👨‍💻 Autor

**Joaquin Uriona**
* [LinkedIn](https://www.linkedin.com/in/Joaquin-Uriona)
* [GitHub](https://github.com/Joako601)

## 🔒 Cláusula de Propiedad y Uso Privado

Este software, incluyendo su código fuente, arquitectura, diseño y documentación, es de **uso estrictamente privado y exclusivo**. Queda terminantemente prohibida la reproducción, distribución, comunicación pública,
transformación o cualquier otra actividad
que se pueda realizar con los contenidos de este repositorio por cualquier persona distinta al autor original,
**Joaquin Uriona**, sin autorización expresa y por escrito.

El acceso a este proyecto se otorga bajo fines de revisión técnica personal y profesional,
manteniendo todos los derechos de propiedad intelectual reservados exclusivamente a su creador.





