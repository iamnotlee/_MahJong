//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: proto/NetGame.proto
namespace proto.NetGame
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"NetUserData")]
    public partial class NetUserData : global::ProtoBuf.IExtensible
    {
        public NetUserData() { }

        private int _uid = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int uid
        {
            get { return _uid; }
            set { _uid = value; }
        }
        private string _image = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"image", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string image
        {
            get { return _image; }
            set { _image = value; }
        }
        private int _idex = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"idex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int idex
        {
            get { return _idex; }
            set { _idex = value; }
        }
        private int _status = default(int);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int status
        {
            get { return _status; }
            set { _status = value; }
        }
        private NetExtraData _extra = null;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"extra", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public NetExtraData extra
        {
            get { return _extra; }
            set { _extra = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"NetExtraData")]
    public partial class NetExtraData : global::ProtoBuf.IExtensible
    {
        public NetExtraData() { }

        private readonly global::System.Collections.Generic.List<int> _list = new global::System.Collections.Generic.List<int>();
        [global::ProtoBuf.ProtoMember(1, Name = @"list", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public global::System.Collections.Generic.List<int> list
        {
            get { return _list; }
        }

        private readonly global::System.Collections.Generic.List<NetKvData> _kvDatas = new global::System.Collections.Generic.List<NetKvData>();
        [global::ProtoBuf.ProtoMember(2, Name = @"kvDatas", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<NetKvData> kvDatas
        {
            get { return _kvDatas; }
        }

        private readonly global::System.Collections.Generic.List<NetOprateData> _operates = new global::System.Collections.Generic.List<NetOprateData>();
        [global::ProtoBuf.ProtoMember(3, Name = @"operates", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<NetOprateData> operates
        {
            get { return _operates; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"NetOprateData")]
    public partial class NetOprateData : global::ProtoBuf.IExtensible
    {
        public NetOprateData() { }

        private int _otype = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"otype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int otype
        {
            get { return _otype; }
            set { _otype = value; }
        }
        private int _uid = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int uid
        {
            get { return _uid; }
            set { _uid = value; }
        }
        private int _dval = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"dval", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int dval
        {
            get { return _dval; }
            set { _dval = value; }
        }
        private int _flag = default(int);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"flag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        private readonly global::System.Collections.Generic.List<int> _dlist = new global::System.Collections.Generic.List<int>();
        [global::ProtoBuf.ProtoMember(5, Name = @"dlist", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public global::System.Collections.Generic.List<int> dlist
        {
            get { return _dlist; }
        }

        private readonly global::System.Collections.Generic.List<NetKvData> _kvDatas = new global::System.Collections.Generic.List<NetKvData>();
        [global::ProtoBuf.ProtoMember(6, Name = @"kvDatas", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<NetKvData> kvDatas
        {
            get { return _kvDatas; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"NetKvData")]
    public partial class NetKvData : global::ProtoBuf.IExtensible
    {
        public NetKvData() { }

        private int _k = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"k", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int k
        {
            get { return _k; }
            set { _k = value; }
        }
        private int _v = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"v", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int v
        {
            get { return _v; }
            set { _v = value; }
        }
        private readonly global::System.Collections.Generic.List<int> _dlist = new global::System.Collections.Generic.List<int>();
        [global::ProtoBuf.ProtoMember(3, Name = @"dlist", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public global::System.Collections.Generic.List<int> dlist
        {
            get { return _dlist; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"RPCreateRoom")]
    public partial class RPCreateRoom : global::ProtoBuf.IExtensible
    {
        public RPCreateRoom() { }

        private int _roomId = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"roomId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int roomId
        {
            get { return _roomId; }
            set { _roomId = value; }
        }
        private int _gameId = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"gameId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int gameId
        {
            get { return _gameId; }
            set { _gameId = value; }
        }
        private global::System.Collections.Generic.List<int> _type = new global::System.Collections.Generic.List<int>();
        [global::ProtoBuf.ProtoMember(3, Name = @"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public global::System.Collections.Generic.List<int> type
        {
            get { return _type; }
            set { _type = value; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"RQCreateRoom")]
    public partial class RQCreateRoom : global::ProtoBuf.IExtensible
    {
        public RQCreateRoom() { }

        private int _roomId = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"roomId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int roomId
        {
            get { return _roomId; }
            set { _roomId = value; }
        }
        private int _gameId = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"gameId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int gameId
        {
            get { return _gameId; }
            set { _gameId = value; }
        }
        private readonly global::System.Collections.Generic.List<NetUserData> _users = new global::System.Collections.Generic.List<NetUserData>();
        [global::ProtoBuf.ProtoMember(3, Name = @"users", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<NetUserData> users
        {
            get { return _users; }
        }

        private readonly global::System.Collections.Generic.List<int> _type = new global::System.Collections.Generic.List<int>();
        [global::ProtoBuf.ProtoMember(4, Name = @"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public global::System.Collections.Generic.List<int> type
        {
            get { return _type; }
        }

        private int _curRount = default(int);
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"curRount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int curRount
        {
            get { return _curRount; }
            set { _curRount = value; }
        }
        private int _gameStatus = default(int);
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"gameStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int gameStatus
        {
            get { return _gameStatus; }
            set { _gameStatus = value; }
        }
        private int _ownerId = default(int);
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"ownerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int ownerId
        {
            get { return _ownerId; }
            set { _ownerId = value; }
        }
        private NetExtraData _extra = null;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"extra", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public NetExtraData extra
        {
            get { return _extra; }
            set { _extra = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"RPEnterRoom")]
    public partial class RPEnterRoom : global::ProtoBuf.IExtensible
    {
        public RPEnterRoom() { }

        private int _roomId = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"roomId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int roomId
        {
            get { return _roomId; }
            set { _roomId = value; }
        }
        private string _key = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string key
        {
            get { return _key; }
            set { _key = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"RQUserStatus")]
    public partial class RQUserStatus : global::ProtoBuf.IExtensible
    {
        public RQUserStatus() { }

        private int _status = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int status
        {
            get { return _status; }
            set { _status = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"RQREsult")]
    public partial class RQREsult : global::ProtoBuf.IExtensible
    {
        public RQREsult() { }

        private int _flag = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"flag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        private readonly global::System.Collections.Generic.List<NetMjUserResult> _users = new global::System.Collections.Generic.List<NetMjUserResult>();
        [global::ProtoBuf.ProtoMember(2, Name = @"users", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<NetMjUserResult> users
        {
            get { return _users; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"NetMjUserResult")]
    public partial class NetMjUserResult : global::ProtoBuf.IExtensible
    {
        public NetMjUserResult() { }

        private readonly global::System.Collections.Generic.List<NetKvData> _scores = new global::System.Collections.Generic.List<NetKvData>();
        [global::ProtoBuf.ProtoMember(1, Name = @"scores", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<NetKvData> scores
        {
            get { return _scores; }
        }

        private int _showType = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"showType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int showType
        {
            get { return _showType; }
            set { _showType = value; }
        }
        private int _winType = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"winType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int winType
        {
            get { return _winType; }
            set { _winType = value; }
        }
        private int _score = default(int);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"score", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int score
        {
            get { return _score; }
            set { _score = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"RQEnterRoom")]
    public partial class RQEnterRoom : global::ProtoBuf.IExtensible
    {
        public RQEnterRoom() { }

        private NetUserData _user = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"user", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public NetUserData user
        {
            get { return _user; }
            set { _user = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"RQExit")]
    public partial class RQExit : global::ProtoBuf.IExtensible
    {
        public RQExit() { }

        private int _uid = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int uid
        {
            get { return _uid; }
            set { _uid = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"RPVote")]
    public partial class RPVote : global::ProtoBuf.IExtensible
    {
        public RPVote() { }

        private bool _isagree = default(bool);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"isagree", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool isagree
        {
            get { return _isagree; }
            set { _isagree = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"RQVote")]
    public partial class RQVote : global::ProtoBuf.IExtensible
    {
        public RQVote() { }

        private bool _isagree = default(bool);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"isagree", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool isagree
        {
            get { return _isagree; }
            set { _isagree = value; }
        }
        private int _uid = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int uid
        {
            get { return _uid; }
            set { _uid = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"RQConnect")]
    public partial class RQConnect : global::ProtoBuf.IExtensible
    {
        public RQConnect() { }

        private int _roomId = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"roomId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int roomId
        {
            get { return _roomId; }
            set { _roomId = value; }
        }
        private int _roleId = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"roleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int roleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"NetResponse")]
    public partial class NetResponse : global::ProtoBuf.IExtensible
    {
        public NetResponse() { }

        private int _status = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int status
        {
            get { return _status; }
            set { _status = value; }
        }
        private readonly global::System.Collections.Generic.List<NetOprateData> _operateDatas = new global::System.Collections.Generic.List<NetOprateData>();
        [global::ProtoBuf.ProtoMember(2, Name = @"operateDatas", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<NetOprateData> operateDatas
        {
            get { return _operateDatas; }
        }

        private int _retStatus;
        [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name = @"retStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int retStatus
        {
            get { return _retStatus; }
            set { _retStatus = value; }
        }
        private int _step = default(int);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"step", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int step
        {
            get { return _step; }
            set { _step = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"NetLoginConfirm")]
    public partial class NetLoginConfirm : global::ProtoBuf.IExtensible
    {
        public NetLoginConfirm() { }

        private int _uid;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int uid
        {
            get { return _uid; }
            set { _uid = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"NetChat")]
    public partial class NetChat : global::ProtoBuf.IExtensible
    {
        public NetChat() { }

        private int _receiveId = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"receiveId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int receiveId
        {
            get { return _receiveId; }
            set { _receiveId = value; }
        }
        private string _userName = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"userName", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private int _channel = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"channel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int channel
        {
            get { return _channel; }
            set { _channel = value; }
        }
        private string _content = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string content
        {
            get { return _content; }
            set { _content = value; }
        }
        private int _isaction = default(int);
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"isaction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int isaction
        {
            get { return _isaction; }
            set { _isaction = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

}