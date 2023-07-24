# Programa de Busqueda de cadenas con tres diferentes algoritmos: Knuth Morris Pratt, Brute Force y Boyer Moore

Este programa en C# consta de tres pantallas y 4 funciones pincipales. En primer lugar, "login", esta función consta de la validación de las credenciales de los usuarios que traten de ingresar al programa. Para este se le pide su codigo y su contraseña. En segundo lugar, "registrar", esta función tiene que ver con la carga de archivos al programa. El programa puede registrar archivos de tipo pdf, word y txt. En tercer lugar, "buscar", esta función consta de la busqueda de alguna palabra u oración en alguno de los archivos registrados por el usuario utilizando alguno de los siguiente algoritmos de busqueda de cadenas: Knuth Morris Pratt, Brute Force o Boyer Moore. Finalmente, la funcion "historial" muestre todos las busquedas realizadas por el usuario, así como el tiempo que se tomó realizaralas y el resultado obtenido.

## 1. Pantalla de Validación de Credenciales

En esta ventana, el usuario debe ingresar sus credenciales para poder acceder a las funcionalidades del programa. Si las credenciales son válidas, se le permitirá avanzar a la segunda pantalla; de lo contrario, el acceso será denegado y se permanecerá en la presente pantalla.

## 2. Pantalla de Gestión de Archivos y Búsqueda de Cadena

Una vez que el usuario ha ingresado con éxito, accederá a esta pantalla, donde encontrará las siguientes funciones:

### 2.1 Cargar y Guardar Archivos

En esta sección, el usuario podrá cargar archivos con los siguientes formatos: PDF, Word (docx) y texto  (txt). Una vez dentro del proyectos, aquellos archivos que no sean de tipo .txt se convertirán a este formato y se alamcenrán en el programa.

### 2.2 Búsqueda de Cadenas

En esta sección, el usuario podrá buscar una palabra u oración específica dentro del archivo de texto previamente cargado y guardado. Para realizar la búsqueda, el programa empleará tres algoritmos diferentes:

1. **Brute Force**: Este algoritmo realiza una búsqueda directa y secuencial de la cadena en el texto.

2. **Knuth Morris Pratt**: Un algoritmo de búsqueda eficiente que utiliza información previa para evitar comparaciones redundantes.

3. **Boyer Moore**: Otro algoritmo de búsqueda eficiente que utiliza un enfoque heurístico para saltar posiciones en el texto.

Una vez finalizadas las búsquedas, el programa mostrará en pantalla la cantidad de veces que se encontró la palabra u oración buscada.

### 2.3 Ver Historial de Búsquedas

En esta sección, el usuario podrá ver el historial de todas las búsquedas realizadas durante la sesión actual. El historial incluirá información sobre las palabras u oraciones buscadas y la cantidad de ocurrencias encontradas.

## Requisitos y Consideraciones

- El programa debe estar desarrollado en C#.
- Se debe implementar una interfaz gráfica (GUI) que permita al usuario interactuar con las diferentes funcionalidades.
- Se recomienda utilizar las bibliotecas o librerías apropiadas para la manipulación de archivos PDF, Word y texto plano.

## Nota

Este es solo un README.md que describe las funcionalidades y características del programa propuesto. No proporciona el código fuente detallado del programa.
