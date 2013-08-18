Module ModuleSocket
    Public Function SerializeMessage(ByVal Messaging As Object) As Object
        Dim MessageSerialize As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim MessageMemoryStream As New System.IO.MemoryStream
        Dim MessageByte() As Byte
        MessageSerialize.Serialize(MessageMemoryStream, Messaging)
        MessageMemoryStream.Position = 0
        ReDim MessageByte(MessageMemoryStream.Length - 1)
        MessageMemoryStream.Read(MessageByte, 0, MessageMemoryStream.Length)
        Return (MessageByte)
    End Function
    Public Function DeserializeMessage(ByVal MessageByte As Object) As Object
        Dim MessageSerialize As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim MessageMemoryStream As New System.IO.MemoryStream
        MessageMemoryStream.Write(MessageByte, 0, MessageByte.Length)
        MessageMemoryStream.Position = 0
        Return (MessageSerialize.Deserialize(MessageMemoryStream))
    End Function
End Module