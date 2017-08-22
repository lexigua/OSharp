﻿// -----------------------------------------------------------------------
//  <copyright file="IEntityDto.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>Chihwei Tian</last-editor>
//  <last-date>2017-08-22 22:51</last-date>
// -----------------------------------------------------------------------
namespace OSharp.Entity
{
    /// <summary>
    /// 定义输入DTO
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IInputDto<TKey>
    {
        /// <summary>
        /// 获取或设置 主键，唯一标识
        /// </summary>
        TKey Id { get; set; }
    }


    /// <summary>
    /// 定义输出DTO
    /// </summary>
    public interface IOutputDto
    { }
}