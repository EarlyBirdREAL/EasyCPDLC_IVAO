using System;

namespace EasyCPDLC;

public class IVAOJSON
{
    public Server[] servers { get; set; }
    public VoiceServer[] voiceServers { get; set; }
    public client clients { get; set; }
}

public class Server
{
    public string? id { get; set; }
    public string? hostname { get; set; }
    public string? ip { get; set; }
    public string? description { get; set; }
    public string? countryId { get; set; }
    public int? currentConnections { get; set; }
    public int? maximumConnections { get; set; }
    
}

public class VoiceServer
{
    public string? id { get; set; }
    public string? hostname { get; set; }
    public string? ip { get; set; }
    public string? description { get; set; }
    public string? countryId { get; set; }
    public int? currentConnections { get; set; }
    public int? maximumConnections { get; set; }
}


public class client
{
    public PilotData[] pilots { get; set; }
    public AtcS[] atcs { get; set; }
    public Observer[] observers { get; set; }
}
public class PilotData
{
    public int? id { get; set; }
    public int? userId { get; set; }
    public string? callsign { get; set; }
    public string? serverId { get; set; }
    public string? softwareTypeId { get; set; }
    public string? softwareVersion { get; set; }
    public int? rating { get; set; }
    public DateTime? createdAt { get; set; }
    public int? time { get; set; }
    public PilotSession pilotSession { get; set; }
    public LastTrack lastTrack { get; set; }
    public FlightPlan? flightPlan { get; set; }
}

public class FlightPlan
{
    public int? id { get; set; }
    public int? revision { get; set; }
    public string? aircraftId { get; set; }
    public string? aircraftNumber { get; set; }
    public string? departureId { get; set; }
    public string? arrivalId { get; set; }
    public string? alternativeId { get; set; }
    public string? alternative2Id { get; set; }
    public string? route { get; set; }
    public string? remarks { get; set; }
    public string? speed { get; set; }
    public string? level { get; set; }
    public string? flightRules { get; set; }
    public string? flightType { get; set; }
    public int? eet { get; set; }
    public int? endurance { get; set; }
    public int? departureTime { get; set; }
    public int? actualDepartureTime { get; set; }
    public int? peopleOnBoard { get; set; }
    public DateTime? createdAt { get; set; }
    public Aircraft aircraft { get; set; }
    public string? aircraftEquipments { get; set; }
    public string? aircraftTransponderTypes { get; set; }
    
}

public class Aircraft
{
    public string? icaoCode { get; set; }
    public string? model { get; set; }
    public string? wakeTurbulence { get; set; }
    public bool? isMilitary { get; set; }
    public string? description { get; set; }
}

public class PilotSession
{
    public string? simulatorId { get; set; }
    public int? textureId { get; set; }
}

public class LastTrack
{
    public int? altitude { get; set; }
    public int? altitudeDifference { get; set; }
    public string? arrivalDistance { get; set; }
    public string? departureDistance { get; set; }
    public int? groundSpeed { get; set; }
    public int? heading { get; set; }
    public string? latitude { get; set; }
    public string? longitude { get; set; }
    public bool? onGround { get; set; }
    public string? state { get; set; }
    public DateTime? timestamp { get; set; }
    public int? transponder { get; set; }
    public string? transponderMode { get; set; }
    public int? time { get; set; }
}

public class AtcS
{
    public int? time { get; set; }
    public int? id { get; set; }
    public int? userId { get; set; }
    public string? callsign { get; set; }
    public string? serverId { get; set; }
    public string? softwareTypeId { get; set; }
    public string? softwareVersion { get; set; }
    public int? rating { get; set; }
    public DateTime? createdAt { get; set; }
    public AtcSession atcSession { get; set; }
    public Atis atis { get; set; }
    public ATCLastTrack lastTrack { get; set; }
}

public class AtcSession
{
    public string? frequency { get; set; }
    public string? position { get; set; }
}

public class Atis
{
    public string[] lines { get; set; }
    public string? revision { get; set; }
    public DateTime? timestamp { get; set; }
}

public class ATCLastTrack
{
    public int? distance { get; set; }
    public string? latitude { get; set; }
    public string? longitude { get; set; }
    public int? time { get; set; }
    public DateTime? timestamp { get; set; }
}

public class Observer
{
    public int? time { get; set; }
    public int? id { get; set; }
    public int? userId { get; set; }
    public string? callsign { get; set; }
    public string? serverId { get; set; }
    public string? softwareTypeId { get; set; }
    public string? softwareVersion { get; set; }
    public int? rating { get; set; }
    public DateTime? createdAt { get; set; }
    public AtcSession atcSession { get; set; }
    public ATCLastTrack lastTrack { get; set; }
}
