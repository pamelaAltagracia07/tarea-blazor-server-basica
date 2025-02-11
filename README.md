# tarea-blazor-server-basica

# Aplicación de Gestión de Vehículos con Blazor

## Descripción
Aplicación web desarrollada con Blazor Server que permite la gestión básica de vehículos.

## Características
- Listado de vehículos
- Agregar nuevos vehículos
- Eliminar vehículos existentes
- Validación de formularios
- Interfaz responsive con Bootstrap 5

## Tecnologías Utilizadas
- .NET 8.0
- Blazor Server
- Bootstrap 5.3.2
- Bootstrap Icons

## Estructura del Proyecto
```
Blazor_app_vehiculos/
├── Components/
│   ├── Layout/
│   │   ├── BarraNavegacion.razor
│   │   └── DiseñoPrincipal.razor
│   └── Pages/
│       ├── Home.razor
│       └── Vehicles.razor
├── Models/
│   └── Vehicle.cs
└── Services/
    └── VehicleService.cs
```

## Lecciones Aprendidas
1. **Gestión de Estado en Blazor**
   - Uso de servicios Scoped para mantener datos en memoria
   - Manejo de estado de componentes con eventos y callbacks

2. **Componentes Reutilizables**
   - Creación de layouts y componentes de navegación
   - Implementación de diseños responsive

3. **Validación de Formularios**
   - Uso de DataAnnotations para validación
   - Implementación de mensajes de error personalizados

4. **Buenas Prácticas**
   - Organización de código por responsabilidades (Models, Services, Components)
   - Uso de namespaces consistentes
