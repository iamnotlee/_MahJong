﻿using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using ProtoBuf;

namespace test
{
    /**************创建房间*****************************/

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

    /**************进入房间*****************************/

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"RQEnterRoom")]
    public partial class RQEnterRoom : global::ProtoBuf.IExtensible
    {
        public RQEnterRoom() { }

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

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"RPEnterRoom")]
    public partial class RPEnterRoom : global::ProtoBuf.IExtensible
    {
        public RPEnterRoom() { }

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


    /**************游戏数据附加值*****************************/

    [Serializable, ProtoContract(Name = @"NetExtraData")]
    public partial class NetExtraData : IExtensible
    {
        public NetExtraData() { }

        private readonly List<int> _list = new List<int>();
        [ProtoMember(1, Name = @"list", DataFormat = DataFormat.TwosComplement)]
        public List<int> list
        {
            get { return _list; }
        }

        private readonly List<NetKvData> _kvDatas = new List<NetKvData>();
        [ProtoMember(2, Name = @"kvDatas", DataFormat = DataFormat.Default)]
        public List<NetKvData> kvDatas
        {
            get { return _kvDatas; }
        }

        private readonly List<NetOprateData> _operates = new List<NetOprateData>();
        [ProtoMember(3, Name = @"operates", DataFormat = DataFormat.Default)]
        public List<NetOprateData> operates
        {
            get { return _operates; }
        }

        private IExtension extensionObject;
        IExtension IExtensible.GetExtensionObject(bool createIfMissing)
        { return Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }



    /**************游戏数据附加值*****************************/


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
    /**************游戏玩家数据*****************************/

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
    /**************游戏操作数据*****************************/

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
}
