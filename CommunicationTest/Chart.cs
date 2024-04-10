using System.Text;
using Utils;

namespace CommunicationTest
{
    internal partial class Chart : Form
    {
        private string? _path;
        private DataEncode _encodeType;
        private int? _count;
        private int _startIndex = 0;
        private int _lenth = 0;
        private DataType? _dataType;
        private bool _isLow = true;
        private bool _isASCII = false;
        private string _formula;
        private bool _History;
        public Chart(string path, DataEncode encodeType, int count, int startIndex, int lenth, DataType dataType, bool isLow, bool isASCII, string formula = "$value")
        {
            InitializeComponent();
            _path = path;
            _encodeType = encodeType;
            _count = count;
            _startIndex = startIndex;
            _lenth = lenth;
            _dataType = dataType;
            _isLow = isLow;
            _formula = formula;
            _isASCII = isASCII;
            Text = _path;
        }

        public async Task DrawChartAsync(byte[] data)
        {
            try
            {
                switch (_encodeType)
                {
                    case DataEncode.Hex:
                        {
                            dynamic rs;
                            switch (_dataType)
                            {
                                case DataType.Float:
                                    rs = StringByteUtils.ToSingle(data, _startIndex, !_isLow!);
                                    break;
                                case DataType.Int16:
                                    rs = StringByteUtils.ToInt16(data, _startIndex, !_isLow!);
                                    break;
                                case DataType.UInt16:
                                    rs = StringByteUtils.ToUInt16(data, _startIndex, !_isLow!);
                                    break;
                                case DataType.Int32:
                                    rs = StringByteUtils.ToInt32(data, _startIndex, !_isLow!);
                                    break;
                                case DataType.UInt32:
                                    rs = StringByteUtils.ToUInt32(data, _startIndex, !_isLow!);
                                    break;
                                case DataType.Int64:
                                    rs = StringByteUtils.ToInt64(data, _startIndex, !_isLow!);
                                    break;
                                case DataType.UInt64:
                                    rs = StringByteUtils.ToUInt64(data, _startIndex, !_isLow!);
                                    break;
                                default: return;
                            }
                            if (_isASCII)
                            {
                                rs = Encoding.ASCII.GetString(data, _startIndex, _lenth);
                            }
                            var calculator = new Calculator();
                            var drs = (double)calculator.Compute(_formula.Replace("$value", Convert.ToString(rs)));
                            _ = await Task.Factory.FromAsync(BeginInvoke(new Action(async () =>
                            {
                                if (realtimeChart1.Series[0].Count > _count)
                                {
                                    realtimeChart1.Series[0].Delete(0);
                                }
                                var time = DateTime.Now;
                                realtimeChart1.Series[0].Add(time.ToOADate(), drs);
                                Text = $"{_path} 最新值:{drs}";
                                if (_History)
                                {
                                    string path = Path.Combine(Application.StartupPath, "History");
                                    if (!string.IsNullOrEmpty(_path))
                                    {
                                        path = Path.Combine(path, _path);
                                    }
                                    if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                                    byte[] rsw = Encoding.Default.GetBytes($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} {drs}\n");
                                    await using var fs = new FileStream(Path.Combine(path, $"{DateTime.Now:yyyyMMdd}_有效数.txt"), FileMode.Append, FileAccess.Write, FileShare.ReadWrite, 8, FileOptions.WriteThrough);
                                    await fs.WriteAsync(rsw);
                                    await fs.FlushAsync();
                                }
                            })), EndInvoke);
                        }
                        break;
                    case DataEncode.ASCII:
                        {
                            dynamic rs;
                            if (!_isASCII)
                            {
                                data = StringByteUtils.StringToBytes(Encoding.ASCII.GetString(data, _startIndex, _lenth));
                                switch (_dataType)
                                {
                                    case DataType.Float:
                                        rs = StringByteUtils.ToSingle(data, 0, !_isLow!);
                                        break;
                                    case DataType.Int16:
                                        rs = StringByteUtils.ToInt16(data, 0, !_isLow!);
                                        break;
                                    case DataType.UInt16:
                                        rs = StringByteUtils.ToUInt16(data, 0, !_isLow!);
                                        break;
                                    case DataType.Int32:
                                        rs = StringByteUtils.ToInt32(data, 0, !_isLow!);
                                        break;
                                    case DataType.UInt32:
                                        rs = StringByteUtils.ToUInt32(data, 0, !_isLow!);
                                        break;
                                    case DataType.Int64:
                                        rs = StringByteUtils.ToInt64(data, 0, !_isLow!);
                                        break;
                                    case DataType.UInt64:
                                        rs = StringByteUtils.ToUInt64(data, 0, !_isLow!);
                                        break;
                                    default: return;
                                }
                            }
                            else
                            {
                                rs = Encoding.ASCII.GetString(data, _startIndex, _lenth);
                            }

                            var calculator = new Calculator();
                            var drs = (double)calculator.Compute(_formula.Replace("$value", Convert.ToString(rs)));
                            _ = await Task.Factory.FromAsync(BeginInvoke(new Action(async () =>
                            {
                                if (realtimeChart1.Series[0].Count > _count)
                                {
                                    realtimeChart1.Series[0].Delete(0);
                                }
                                var time = DateTime.Now;
                                realtimeChart1.Series[0].Add(time.ToOADate(), drs);
                                Text = $"{_path} 最新值:{drs}";
                                if (_History)
                                {
                                    string path = Path.Combine(Application.StartupPath, "History");
                                    if (!string.IsNullOrEmpty(_path))
                                    {
                                        path = Path.Combine(path, _path);
                                    }
                                    if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                                    byte[] rsw = Encoding.Default.GetBytes($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} {drs}\n");
                                    await using var fs = new FileStream(Path.Combine(path, $"{DateTime.Now:yyyyMMdd}_有效数.txt"), FileMode.Append, FileAccess.Write, FileShare.Read, 8, FileOptions.WriteThrough);
                                    await fs.WriteAsync(rsw);
                                    await fs.FlushAsync();
                                }
                            })), EndInvoke);
                        }
                        break;
                    case DataEncode.UTF8:
                        {
                            dynamic rs;
                            if (!_isASCII)
                            {
                                data = StringByteUtils.StringToBytes(Encoding.UTF8.GetString(data, _startIndex, _lenth));
                                switch (_dataType)
                                {
                                    case DataType.Float:
                                        rs = StringByteUtils.ToSingle(data, 0, !_isLow!);
                                        break;
                                    case DataType.Int16:
                                        rs = StringByteUtils.ToInt16(data, 0, !_isLow!);
                                        break;
                                    case DataType.UInt16:
                                        rs = StringByteUtils.ToUInt16(data, 0, !_isLow!);
                                        break;
                                    case DataType.Int32:
                                        rs = StringByteUtils.ToInt32(data, 0, !_isLow!);
                                        break;
                                    case DataType.UInt32:
                                        rs = StringByteUtils.ToUInt32(data, 0, !_isLow!);
                                        break;
                                    case DataType.Int64:
                                        rs = StringByteUtils.ToInt64(data, 0, !_isLow!);
                                        break;
                                    case DataType.UInt64:
                                        rs = StringByteUtils.ToUInt64(data, 0, !_isLow!);
                                        break;
                                    default: return;
                                }
                            }
                            else
                            {
                                rs = Encoding.UTF8.GetString(data, _startIndex, _lenth);
                            }

                            var calculator = new Calculator();
                            var drs = (double)calculator.Compute(_formula.Replace("$value", Convert.ToString(rs)));
                            _ = await Task.Factory.FromAsync(BeginInvoke(new Action(async () =>
                            {
                                if (realtimeChart1.Series[0].Count > _count)
                                {
                                    realtimeChart1.Series[0].Delete(0);
                                }
                                var time = DateTime.Now;
                                realtimeChart1.Series[0].Add(time.ToOADate(), drs);
                                Text = $"{_path} 最新值:{drs}";
                                if (_History)
                                {
                                    string path = Path.Combine(Application.StartupPath, "History");
                                    if (!string.IsNullOrEmpty(_path))
                                    {
                                        path = Path.Combine(path, _path);
                                    }
                                    if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                                    byte[] rsw = Encoding.Default.GetBytes($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} {drs}\n");
                                    await using var fs = new FileStream(Path.Combine(path, $"{DateTime.Now:yyyyMMdd}_有效数.txt"), FileMode.Append, FileAccess.Write, FileShare.Read, 8, FileOptions.WriteThrough);
                                    await fs.WriteAsync(rsw);
                                    await fs.FlushAsync();
                                }
                            })), EndInvoke);
                        }
                        break;
                    case DataEncode.GB2312:
                        {
                            dynamic rs;
                            if (!_isASCII)
                            {
                                data = StringByteUtils.StringToBytes(Encoding.GetEncoding("GB2312").GetString(data, _startIndex, _lenth));
                                switch (_dataType)
                                {
                                    case DataType.Float:
                                        rs = StringByteUtils.ToSingle(data, 0, !_isLow!);
                                        break;
                                    case DataType.Int16:
                                        rs = StringByteUtils.ToInt16(data, 0, !_isLow!);
                                        break;
                                    case DataType.UInt16:
                                        rs = StringByteUtils.ToUInt16(data, 0, !_isLow!);
                                        break;
                                    case DataType.Int32:
                                        rs = StringByteUtils.ToInt32(data, 0, !_isLow!);
                                        break;
                                    case DataType.UInt32:
                                        rs = StringByteUtils.ToUInt32(data, 0, !_isLow!);
                                        break;
                                    case DataType.Int64:
                                        rs = StringByteUtils.ToInt64(data, 0, !_isLow!);
                                        break;
                                    case DataType.UInt64:
                                        rs = StringByteUtils.ToUInt64(data, 0, !_isLow!);
                                        break;
                                    default: return;
                                }
                            }
                            else
                            {
                                rs = Encoding.GetEncoding("GB2312").GetString(data, _startIndex, _lenth);
                            }

                            var calculator = new Calculator();
                            var drs = (double)calculator.Compute(_formula.Replace("$value", Convert.ToString(rs)));
                            _ = await Task.Factory.FromAsync(BeginInvoke(new Action(async () =>
                            {
                                if (realtimeChart1.Series[0].Count > _count)
                                {
                                    realtimeChart1.Series[0].Delete(0);
                                }
                                var time = DateTime.Now;
                                realtimeChart1.Series[0].Add(time.ToOADate(), drs);
                                Text = $"{_path} 最新值:{drs}";
                                if (_History)
                                {
                                    string path = Path.Combine(Application.StartupPath, "History");
                                    if (!string.IsNullOrEmpty(_path))
                                    {
                                        path = Path.Combine(path, _path);
                                    }
                                    if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                                    byte[] rsw = Encoding.Default.GetBytes($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} {drs}\n");
                                    await using var fs = new FileStream(Path.Combine(path, $"{DateTime.Now:yyyyMMdd}_有效数.txt"), FileMode.Append, FileAccess.Write, FileShare.Read, 8, FileOptions.WriteThrough);
                                    await fs.WriteAsync(rsw);
                                    await fs.FlushAsync();
                                }
                            })), EndInvoke);
                        }
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

        private void 存储有效值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _History = 存储有效值ToolStripMenuItem.Checked;
        }

        private void 清图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            realtimeChart1.Series[0].Clear();
        }
    }
}
