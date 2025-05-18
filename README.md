Editor.md
Editor de Markdown en línea de código abierto.

a. Qué hace el proyecto.
b. Por qué el proyecto es útil.
do. Cómo pueden comenzar los usuarios con el proyecto.
d. Dónde pueden recibir ayuda los usuarios con tu proyecto.
mi. Quién mantiene y contribuye con el proyecto.

Ejemplo
<link rel="hoja de estilo" href="editormd/css/editormd.css" />
<div id="editor-de-prueba">
    <textarea style="display:none;">### Editor.md

**Editor.md**: El editor de rebajas en línea integrable de código abierto, basado en CodeMirror, jQuery y Marked.
    </área de texto>
</div>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
<script src="editormd/editormd.min.js"></script>
<script type="texto/javascript">
    $(función() {
        var editor = editormd("editor-de-pruebas", {
            // ancho: "100%",
            // altura: "100%",
            ruta: "editormd/lib/"
        });
    });
</script>
Copiar
Más ejemplos >>

Características
Admite Markdown estándar / CommonMark y GFM (Markdown con formato GitHub);
Completamente funcional: vista previa en tiempo real, carga de imágenes (entre dominios) , inserción de texto preformateado/bloques de código/tablas, plegado de código, reemplazo de búsqueda, solo lectura, temas, varios idiomas, L18n, entidades HTML, resaltado de sintaxis de código...;
Extras de Markdown: Soporte para ToC (Tabla de Contenidos) , Emoji , Listas de tareas , @Enlaces ...;
Soporte TeX (expresiones LaTeX, basadas en KaTeX) , diagrama de flujo y diagrama de secuencia de sintaxis extendida de Markdown;
Admite identificación, interpretación y filtrado de etiquetas HTML;
Admite cargador de módulos AMD/CMD (Require.js y Sea.js) y complementos de editor personalizados/definidos;
Compatible con los principales navegadores (IE8+), compatible con Zepto.js y iPad;
Admite estilos de temas personalizados;
Descargar e instalar
Última versión: v1.5.0, Actualización: 09/06/2015



 


O instalar NPM:

npm install editor.md



O instalación de Bower:

bower install editor.md




Registros de cambios:

CAMBIOS

Dependientes
Proyectos :

Espejo de código
marcado
jQuery
Fuente increíble
github-markdown.css
KaTeX
Rephael.js
prettify.js
diagrama de flujo.js
diagrama de secuencia.js
Prefijos.scss

Herramientas de desarrollo:

Código de Visual Studio
Sass/Scss
Gulp.js
Licencia
Editor.md sigue la licencia MIT , cualquiera puede usarlo libremente.





Bifurcame en Github:







Usuarios

Contáctenos: editor.md@ipandao.com


Editor.md

Copyright © 2015-2019 Editor.md , licencia MIT.

Diseño y desarrollo por: Pandao     
