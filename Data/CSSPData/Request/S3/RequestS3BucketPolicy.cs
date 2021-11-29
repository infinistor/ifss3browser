/*
* Copyright (c) 2021 PSPACE, inc. KSAN Development Team ksan@pspace.co.kr
* KSAN is a suite of free software: you can redistribute it and/or modify it under the terms of
* the GNU General Public License as published by the Free Software Foundation, either version 
* 3 of the License.  See LICENSE for details
*
* 본 프로그램 및 관련 소스코드, 문서 등 모든 자료는 있는 그대로 제공이 됩니다.
* KSAN 프로젝트의 개발자 및 개발사는 이 프로그램을 사용한 결과에 따른 어떠한 책임도 지지 않습니다.
* KSAN 개발팀은 사전 공지, 허락, 동의 없이 KSAN 개발에 관련된 모든 결과물에 대한 LICENSE 방식을 변경 할 권리가 있습니다.
*/
using System.Collections.Generic;
using System.Text.Json.Serialization;
using CSSPData.Enums;
using MTLib.Core;

namespace CSSPData.Request.S3
{
	/// <summary>S3 버킷 정책 요청 클래스</summary>
	public class RequestS3BucketPolicy
	{
		/// <summary>정책</summary>
		public string Policy { get; set; } = "";
	}

	// /// <summary>
	// /// S3 버킷 정책 요청 클래스
	// /// </summary>
	// public class RequestS3BucketPolicy
	// {
	// 	/// <summary>
	// 	/// 아이디
	// 	/// </summary>
	// 	public string Id { get; set; } = "";
	//
	// 	/// <summary>
	// 	/// Version
	// 	/// </summary>
	// 	public string Version { get; set; } = "";
	//
	// 	/// <summary>
	// 	/// 정책 목록
	// 	/// </summary>
	// 	public List<RequestS3BucketPolicyItem> Statements { get; set; } = new List<RequestS3BucketPolicyItem>();
	// }

	// /// <summary>
	// /// S3 버킷 정책 항목 클래스
	// /// </summary>
	// public class RequestS3BucketPolicyItem
	// {
	// 	/// <summary>
	// 	/// SID
	// 	/// </summary>
	// 	public string Sid { get; set; } = "";
	// 	
	// 	/// <summary>
	// 	/// S3 버킷 정책 적용 타입
	// 	/// </summary>
	// 	public EnumS3BucketPolicyEffectType Effect { get; set; } = EnumS3BucketPolicyEffectType.Allow;
	//
	// 	/// <summary>
	// 	/// 자격 목록 (','으로 구분)
	// 	/// </summary>
	// 	public string Principal { get; set; } = "";
	//
	// 	/// <summary>
	// 	/// Actions
	// 	/// </summary>
	// 	public List<EnumS3BucketPolicyActionType> Actions { get; set; } = new List<EnumS3BucketPolicyActionType>();
	//
	// 	/// <summary>
	// 	/// 리소스명 목록 (','으로 구분)
	// 	/// </summary>
	// 	public string ResourceName { get; set; } = "";
	// }
}