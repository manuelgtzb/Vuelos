using MongoDB.Bson.Serialization.Attributes;

public class Vuelo {
  [BsonId]
  [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

  public string? Id { get; set; }

  [BsonElement("pais_origen")]
  public string pais_origen { get; set; } = string.Empty;
[BsonElement("ciudad_origen")]
  public string ciudad_origen { get; set; } = string.Empty;
[BsonElement("aeropuerto_origen")]
  public string aeropuerto_origen { get; set; } = string.Empty;
[BsonElement("pais_destino")]
  public string pais_destino { get; set; } = string.Empty;
[BsonElement("ciudad_destino")]
  public string ciudad_destino { get; set; } = string.Empty;
[BsonElement("aeropuerto_destino")]
  public string aeropuerto_destino { get; set; } = string.Empty;
[BsonElement("tipo_avion")]
  public string tipo_avion { get; set; } = string.Empty;
[BsonElement("cupo_avion")]
  public int cupo_avion { get; set; }
[BsonElement("pasajeros_actuales")]
  public int pasajeros_actuales { get; set; }
[BsonElement("fecha_hora_salida")]
  public DateTime fecha_hora_salida { get; set; }
[BsonElement("fecha_hora_llegada_aproximada")]
  public DateTime fecha_hora_llegada_aproximada { get; set; }
[BsonElement("nombre_piloto")]
  public string nombre_piloto { get; set; } = string.Empty;
[BsonElement("estatus_vuelo")]
  public string estatus_vuelo { get; set; } = string.Empty;



}