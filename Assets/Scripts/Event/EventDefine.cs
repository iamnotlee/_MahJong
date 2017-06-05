﻿//---------------------------------------------------------------------------------------
// Copyright (c) BOLO 2016-2017
// Author: slove
// Date: 2016-6-2
// Description: 游戏事件定义
//---------------------------------------------------------------------------------------
using UnityEngine;
using System;
//---------------------------------------------------------------------
// 事件枚举
//---------------------------------------------------------------------
public enum EEventId : int
{
   
    UpdateMahjong
  



 

}

//---------------------------------------------------------------------
// 事件结构
//---------------------------------------------------------------------
public struct EventParam
{
    private int _id;
    private object _data;

    public int id { get { return _id; } }

    public object Data { get { return _data; } }

    //---------------------------------------------------------------------
    // 双参构造
    //---------------------------------------------------------------------
    public EventParam(int id, object data)
    {
        _id = id;
        _data = data;
    }

    //---------------------------------------------------------------------
    // 单参构造
    //---------------------------------------------------------------------
    public EventParam(int id)
    {
        _id = id;
        _data = null;
    }
    //---------------------------------------------------------------------
    // 构造
    //---------------------------------------------------------------------
    public EventParam(EEventId id, object data = null)
    {
        _id = (int)id;
        _data = data;
    }

    //---------------------------------------------------------------------
    // 获取数据
    //---------------------------------------------------------------------
    public T GetData<T>()
    {
        return (T)_data;
    }
}





