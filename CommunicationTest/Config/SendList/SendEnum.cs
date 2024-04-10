namespace CommunicationTest.Config.SendList
{
    public enum SendType
    {
        Hex,
        ASCII,
        UTF8,
        GB2312
    }

    public enum CrcType
    {
        None,
        Modbus,
        Crc16_R,
        UpdateCRC,
        GBcrc16,
        HBcrc16,
        GBcrc16_string,
        HBcrc16_string,
        H_GBcrc16_string,
        H_HBcrc16_string
    }
}