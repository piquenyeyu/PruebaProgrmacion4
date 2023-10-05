using PruebaProgrmacion4;

Celular fotografia = new();
Tablet gps = new();

Console.WriteLine(fotografia.MostrarAppCamara());
fotografia.TomarFotografia("coordenadas", "N 120");
Console.WriteLine(gps.Localizar());
Console.WriteLine(gps.ObtenerCoordenadas());
