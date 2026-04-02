# TerrainUnityDom-nicaTer-n
Terrain realizado en unity con una bola en movimiento 
READ ME: 
Sphere Odyssey
	Un proyecto de exploración en 3D con Unity que combina paisajes surrealistas, esferas de diferentes materiales rotando y una bola que viaja a través. Se intentó evocar tranquilidad, naturaleza y me inspiré en Magritte.
Es una experiencia de exploración donde el jugador controla una esfera a través de dos terrenos con texturas y elevaciones variadas. El objetivo es navegar por un mundo onírico, la interacción con objetos que aparentan ser cinematográficos y encontrar un camino de regreso a un spot en la nieve. 
Características Técnicas
-	Entorno y Mundo
o	Dual Terrain: use dos terrenos con diferentes capas de textura y mapas de altura (heightmaps) para crear valles y zonas elevadas
o	Atmosfera Surrealista: mi diseño es centrado en la tranquilidad, utilizando materiales experimentales y una estética que evoca espacios naturales bellos y abstractos 
o	Obstáculos Dinámicos: el mundo cuenta con 11 figuras en movimiento con dos tipos de rotaciones programadas por script, además de elementos decorativos como piedras y múltiples esferas con texturas variadas.
-	Mecánicas de Jugador
o	Physics-Based Movement: control de la bola principal mediante las flechas del teclado, usando fuerzas físicas
o	Controlo de Fricción: implementación del physics material personalizado que ajusta la fricción y rebote, evitando que la esfera pierda el contacto con el suelo en altas velocidades
o	Sistema de Seguimiento de Cámara: script personalizado adjunto de main camera que instancia y sigue la posición de la bola en tiempo real para una navegación fluida. 
-	Configuración y Personalización (Inspector)
o	Gracias a [SerializeField] podemos ajustar los siguientes parámetros directamente desde el editor del Unity sin editar el código:
	Speed: velocidad e la bola
	Mass: peso físico para colisiones mas realistas 
	Size: eso para ir midiendo como queda 
-	Cómo Jugar
o	Movimiento: usar flechas del teclado para dirigir a la bola 
o	Objetvio: explorar el mapa, observar 11 figuras rotatorias y dirigirse a una zona de nieve donde hay un espacio para la bola
o	OJO: Con los bordes del terreno a veces sale volando la bola si vas muy rápido y te chocas 
-	Estructura de Scripts Principales:
o	PlayerController: gestión inputs y fuerzas aplicadas en el rigid body
o	FollowPlayer: Lógica de suavizado y seguimiento de la cámara a la bolita
o	RotadorCapsula y RotadorBolaAgua: Scripts aplicados a las 11 figuras para generar los dos tipos de rotación ambiental
