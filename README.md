# ProyectoFinalAP2

Siguiendo las instrucciones dadas a continuación el usuario podra manejar el sistema de una manera correcta, sin cometer errores algunos.

Al ingresar al sistema usted deberá loggearse para poder tener acceso a los diversos componentes del sistema, para hacerlo puede hacer click en las siguientes opciones

-----------Insertar imagen del login

En este registro debemos ingresar el Usuario y la contraseña de un Usuario previamente registrados para poder acceder, en caso de no haber creado ningun usuario o ser la primera vez que accede al sistema 
el Usuario será: admin y la contraseña: admin. Luego de ingresados los datos se accede pulsando el botón de Ingresar.

Luego de ingresado se pueden cambiar los datos de este usuario. Además, sólo el administrador tiene acceso a editar, crear y consultar usuarios.

# Registros
## Pacientes

![RegistroPacientes](https://user-images.githubusercontent.com/54722249/89110893-8c3a6a00-d41d-11ea-93db-30f12239be64.png)


Esta página permite al usuario registrar nuevos pacientes, de igual modo modificar y eliminar pacientes existentes. 

## Tipos de Procedimientos

![RegistroTiposProcedimientos](https://user-images.githubusercontent.com/54722249/89110925-04a12b00-d41e-11ea-9c0c-3b2aa0c5f345.png)

Esta página permite al usuario la creación de nuevos tipos de procedimientos, los cuales se podrán seleccionar desde la pagina de Procedimientos. Aquí además se puede Modificar y Eliminar Tios de rocedimientos.

## Procedimientos

![image](https://user-images.githubusercontent.com/54722249/89112441-9d40a680-d430-11ea-899e-d01d2927e94f.png)


Esta página permite al usuario guardar la informacion sobre un determinado proceso que se le comience a realizar a un determinado paciente, En este podemos ir agregando como detalle las citas que el paciente vaya agotando, con una descripción de los que se avanzó o se hizo en esta cita, hasta terminar el procedimiento.

## Usuarios

![image](https://user-images.githubusercontent.com/54722249/89112453-d24cf900-d430-11ea-8ffa-3f32660beddc.png)

En esta pagina los usuarios con nivel de administrador podrán registrar nuevos usuarios, asi como modificar información de un determinado usuario o eliminarlo.

## Citas

![citas](https://user-images.githubusercontent.com/31710186/89184713-35d94280-d567-11ea-8398-c140954f017f.PNG)

En este registro podremos crear nuevas citas, Las cuales para poder Guardar no debe coincidir la hora de ese dia, con la hora de una cita ya programada para el mismo dia. Además nos permite Eliminar o Modificar Citas ya creadas.

## Tipo de Citas

![tipo_citas](https://user-images.githubusercontent.com/31710186/89184721-370a6f80-d567-11ea-810e-93dce77a25e2.PNG)

En este registro podremos crear los tipos de citas, ademas de permitirnos Eliminar o Modificar tipos de citas ya creadas.

## Seguros

![seguros](https://user-images.githubusercontent.com/31710186/89184720-370a6f80-d567-11ea-8245-56f969d63e1f.PNG)

En este registro podremos crear los tipos de seguros que tendran cobertura para los pacientes. Este ademas de crearlos, nos permitira eliminar o modificar cualquier seguro ya creado.

## Cobros

![cobros](https://user-images.githubusercontent.com/31710186/89184717-3671d900-d567-11ea-914d-fb94646c9258.PNG)

En este registro se aplicaran los cobros a los pacientes en forma de abonos, se guardaran tanto los cobros, como tambien se podran modificar y eliminar.
En base a este registro se le iran restando, en base a los cobros, el balance cargado a cada paciente.

# Consultas

![image](https://user-images.githubusercontent.com/54722249/89112472-14763a80-d431-11ea-967c-06aeaa218ffc.png)

Esta es la Consulta de pacientes, en la cual se puede filtrar por id, nombres, apellidos, direccion y balance. Al pulsar el botón consultar, se cargaran en la tabla los datos que cumplan con los filtros dados. Cabe destacar que si no se coloca ningun filtro, se cargaran todos los datos de esta entidad.

Cuenta con una sumatoria de los balances.

Además cuenta con un botón de imprimir el cual nos imprime un reporte que tambien cumple con los filtros realizados en la consulta.

Las demás consultas son similares a esta, solo variando parte de sus filtros.


# Autores del Proyecto

Jeferson Raul Ortega Brito ------- 2017-0595

Natanael Ureña Fernández ------- 2019-0454

# Herramientas Empleadas en este proyecto

  
    -Visual Studio Blazor -Heramienta de Desarrollo
    -SQLite -Gestor de Base de Datos
    -Microsoft Chromium Edge -Navegador usado para ejecutar las pruebas y para buscar ayudas para diversas situaciones que se presentaron en el desarrollo.

# Agradecimientos

A nuestro profesor Enel Almonte, el cual puso todo su esfuerzo en que aprendieramos lo necesario en la asignatura Programación Aplicada 2, puso en marcha diversas estrategias para hacer más fácil el proceso de aprendizaje y que sus estudiantes pusieramos empeño en aprender, y saber solucionar errores.

Opinión personal de Jeferson: Agradezco mucho a Enel que tanto se esforzó por enseñarnos, tanto en esta asignatura como en la anterior, estoy encantado de haber podido tener un profesor como usted, que se esfuerza en ganar la confianza de sus estudiantes, haciendo que fuera más facil comprender la asignatura. Ha sido un gran placer para mi tenerlo como profesor.

# Objetivos

Esperando que este proyecto pueda cumplir con las espectativas.
