#pragma warning disable 612,618
#pragma warning disable 0114
#pragma warning disable 0108

using System;
using System.Collections.Generic;
using GameSparks.Core;
using GameSparks.Api.Requests;
using GameSparks.Api.Responses;

//THIS FILE IS AUTO GENERATED, DO NOT MODIFY!!
//THIS FILE IS AUTO GENERATED, DO NOT MODIFY!!
//THIS FILE IS AUTO GENERATED, DO NOT MODIFY!!

namespace GameSparks.Api.Requests{
		public class LogEventRequest_acceptFriendRequest : GSTypedRequest<LogEventRequest_acceptFriendRequest, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_acceptFriendRequest() : base("LogEventRequest"){
			request.AddString("eventKey", "acceptFriendRequest");
		}
		
		public LogEventRequest_acceptFriendRequest Set_friendId( string value )
		{
			request.AddString("friendId", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_acceptFriendRequest : GSTypedRequest<LogChallengeEventRequest_acceptFriendRequest, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_acceptFriendRequest() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "acceptFriendRequest");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_acceptFriendRequest SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_acceptFriendRequest Set_friendId( string value )
		{
			request.AddString("friendId", value);
			return this;
		}
	}
	
	public class LogEventRequest_CURRENCY_ADD : GSTypedRequest<LogEventRequest_CURRENCY_ADD, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_CURRENCY_ADD() : base("LogEventRequest"){
			request.AddString("eventKey", "CURRENCY_ADD");
		}
		public LogEventRequest_CURRENCY_ADD Set_ELIXIRE_CURR( long value )
		{
			request.AddNumber("ELIXIRE_CURR", value);
			return this;
		}			
		public LogEventRequest_CURRENCY_ADD Set_GEM_CURR( long value )
		{
			request.AddNumber("GEM_CURR", value);
			return this;
		}			
		public LogEventRequest_CURRENCY_ADD Set_GAS_CURR( long value )
		{
			request.AddNumber("GAS_CURR", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_CURRENCY_ADD : GSTypedRequest<LogChallengeEventRequest_CURRENCY_ADD, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_CURRENCY_ADD() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "CURRENCY_ADD");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_CURRENCY_ADD SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_CURRENCY_ADD Set_ELIXIRE_CURR( long value )
		{
			request.AddNumber("ELIXIRE_CURR", value);
			return this;
		}			
		public LogChallengeEventRequest_CURRENCY_ADD Set_GEM_CURR( long value )
		{
			request.AddNumber("GEM_CURR", value);
			return this;
		}			
		public LogChallengeEventRequest_CURRENCY_ADD Set_GAS_CURR( long value )
		{
			request.AddNumber("GAS_CURR", value);
			return this;
		}			
	}
	
	public class LogEventRequest_Award_Achievement : GSTypedRequest<LogEventRequest_Award_Achievement, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_Award_Achievement() : base("LogEventRequest"){
			request.AddString("eventKey", "Award_Achievement");
		}
	}
	
	public class LogChallengeEventRequest_Award_Achievement : GSTypedRequest<LogChallengeEventRequest_Award_Achievement, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_Award_Achievement() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "Award_Achievement");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_Award_Achievement SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_declineFriendRequest : GSTypedRequest<LogEventRequest_declineFriendRequest, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_declineFriendRequest() : base("LogEventRequest"){
			request.AddString("eventKey", "declineFriendRequest");
		}
		
		public LogEventRequest_declineFriendRequest Set_friendId( string value )
		{
			request.AddString("friendId", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_declineFriendRequest : GSTypedRequest<LogChallengeEventRequest_declineFriendRequest, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_declineFriendRequest() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "declineFriendRequest");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_declineFriendRequest SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_declineFriendRequest Set_friendId( string value )
		{
			request.AddString("friendId", value);
			return this;
		}
	}
	
	public class LogEventRequest_event_EndGame : GSTypedRequest<LogEventRequest_event_EndGame, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_event_EndGame() : base("LogEventRequest"){
			request.AddString("eventKey", "event_EndGame");
		}
		public LogEventRequest_event_EndGame Set_score( long value )
		{
			request.AddNumber("score", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_event_EndGame : GSTypedRequest<LogChallengeEventRequest_event_EndGame, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_event_EndGame() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "event_EndGame");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_event_EndGame SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_event_EndGame Set_score( long value )
		{
			request.AddNumber("score", value);
			return this;
		}			
	}
	
	public class LogEventRequest_event_InputScore : GSTypedRequest<LogEventRequest_event_InputScore, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_event_InputScore() : base("LogEventRequest"){
			request.AddString("eventKey", "event_InputScore");
		}
		public LogEventRequest_event_InputScore Set_score( long value )
		{
			request.AddNumber("score", value);
			return this;
		}			
		
		public LogEventRequest_event_InputScore Set_league( string value )
		{
			request.AddString("league", value);
			return this;
		}
		public LogEventRequest_event_InputScore Set_division( long value )
		{
			request.AddNumber("division", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_event_InputScore : GSTypedRequest<LogChallengeEventRequest_event_InputScore, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_event_InputScore() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "event_InputScore");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_event_InputScore SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_event_InputScore Set_score( long value )
		{
			request.AddNumber("score", value);
			return this;
		}			
		public LogChallengeEventRequest_event_InputScore Set_league( string value )
		{
			request.AddString("league", value);
			return this;
		}
		public LogChallengeEventRequest_event_InputScore Set_division( long value )
		{
			request.AddNumber("division", value);
			return this;
		}			
	}
	
	public class LogEventRequest_EV_LB_CO : GSTypedRequest<LogEventRequest_EV_LB_CO, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_EV_LB_CO() : base("LogEventRequest"){
			request.AddString("eventKey", "EV_LB_CO");
		}
		public LogEventRequest_EV_LB_CO Set_AT_LB_LVL( long value )
		{
			request.AddNumber("AT_LB_LVL", value);
			return this;
		}			
		
		public LogEventRequest_EV_LB_CO Set_AT_LB_CO( string value )
		{
			request.AddString("AT_LB_CO", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_EV_LB_CO : GSTypedRequest<LogChallengeEventRequest_EV_LB_CO, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_EV_LB_CO() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "EV_LB_CO");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_EV_LB_CO SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_EV_LB_CO Set_AT_LB_LVL( long value )
		{
			request.AddNumber("AT_LB_LVL", value);
			return this;
		}			
		public LogChallengeEventRequest_EV_LB_CO Set_AT_LB_CO( string value )
		{
			request.AddString("AT_LB_CO", value);
			return this;
		}
	}
	
	public class LogEventRequest_EV_LVL_TEAM : GSTypedRequest<LogEventRequest_EV_LVL_TEAM, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_EV_LVL_TEAM() : base("LogEventRequest"){
			request.AddString("eventKey", "EV_LVL_TEAM");
		}
		public LogEventRequest_EV_LVL_TEAM Set_ATT_LVL_TEAM( long value )
		{
			request.AddNumber("ATT_LVL_TEAM", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_EV_LVL_TEAM : GSTypedRequest<LogChallengeEventRequest_EV_LVL_TEAM, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_EV_LVL_TEAM() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "EV_LVL_TEAM");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_EV_LVL_TEAM SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_EV_LVL_TEAM Set_ATT_LVL_TEAM( long value )
		{
			request.AddNumber("ATT_LVL_TEAM", value);
			return this;
		}			
	}
	
	public class LogEventRequest_event_Placement : GSTypedRequest<LogEventRequest_event_Placement, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_event_Placement() : base("LogEventRequest"){
			request.AddString("eventKey", "event_Placement");
		}
		public LogEventRequest_event_Placement Set_score( long value )
		{
			request.AddNumber("score", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_event_Placement : GSTypedRequest<LogChallengeEventRequest_event_Placement, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_event_Placement() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "event_Placement");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_event_Placement SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_event_Placement Set_score( long value )
		{
			request.AddNumber("score", value);
			return this;
		}			
	}
	
	public class LogEventRequest_EV_XP_LB_GL : GSTypedRequest<LogEventRequest_EV_XP_LB_GL, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_EV_XP_LB_GL() : base("LogEventRequest"){
			request.AddString("eventKey", "EV_XP_LB_GL");
		}
		public LogEventRequest_EV_XP_LB_GL Set_AT_XP_LB_GL( long value )
		{
			request.AddNumber("AT_XP_LB_GL", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_EV_XP_LB_GL : GSTypedRequest<LogChallengeEventRequest_EV_XP_LB_GL, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_EV_XP_LB_GL() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "EV_XP_LB_GL");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_EV_XP_LB_GL SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_EV_XP_LB_GL Set_AT_XP_LB_GL( long value )
		{
			request.AddNumber("AT_XP_LB_GL", value);
			return this;
		}			
	}
	
	public class LogEventRequest_findPlayers : GSTypedRequest<LogEventRequest_findPlayers, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_findPlayers() : base("LogEventRequest"){
			request.AddString("eventKey", "findPlayers");
		}
	}
	
	public class LogChallengeEventRequest_findPlayers : GSTypedRequest<LogChallengeEventRequest_findPlayers, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_findPlayers() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "findPlayers");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_findPlayers SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_friendRequest : GSTypedRequest<LogEventRequest_friendRequest, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_friendRequest() : base("LogEventRequest"){
			request.AddString("eventKey", "friendRequest");
		}
		
		public LogEventRequest_friendRequest Set_friendId( string value )
		{
			request.AddString("friendId", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_friendRequest : GSTypedRequest<LogChallengeEventRequest_friendRequest, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_friendRequest() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "friendRequest");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_friendRequest SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_friendRequest Set_friendId( string value )
		{
			request.AddString("friendId", value);
			return this;
		}
	}
	
	public class LogEventRequest_friendRequestReceived : GSTypedRequest<LogEventRequest_friendRequestReceived, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_friendRequestReceived() : base("LogEventRequest"){
			request.AddString("eventKey", "friendRequestReceived");
		}
	}
	
	public class LogChallengeEventRequest_friendRequestReceived : GSTypedRequest<LogChallengeEventRequest_friendRequestReceived, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_friendRequestReceived() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "friendRequestReceived");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_friendRequestReceived SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_friendRequestSent : GSTypedRequest<LogEventRequest_friendRequestSent, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_friendRequestSent() : base("LogEventRequest"){
			request.AddString("eventKey", "friendRequestSent");
		}
	}
	
	public class LogChallengeEventRequest_friendRequestSent : GSTypedRequest<LogChallengeEventRequest_friendRequestSent, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_friendRequestSent() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "friendRequestSent");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_friendRequestSent SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_Get_Named_Curr : GSTypedRequest<LogEventRequest_Get_Named_Curr, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_Get_Named_Curr() : base("LogEventRequest"){
			request.AddString("eventKey", "Get_Named_Curr");
		}
	}
	
	public class LogChallengeEventRequest_Get_Named_Curr : GSTypedRequest<LogChallengeEventRequest_Get_Named_Curr, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_Get_Named_Curr() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "Get_Named_Curr");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_Get_Named_Curr SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_getPlayerFriends : GSTypedRequest<LogEventRequest_getPlayerFriends, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_getPlayerFriends() : base("LogEventRequest"){
			request.AddString("eventKey", "getPlayerFriends");
		}
	}
	
	public class LogChallengeEventRequest_getPlayerFriends : GSTypedRequest<LogChallengeEventRequest_getPlayerFriends, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_getPlayerFriends() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "getPlayerFriends");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_getPlayerFriends SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_getPlayerOfflineFriends : GSTypedRequest<LogEventRequest_getPlayerOfflineFriends, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_getPlayerOfflineFriends() : base("LogEventRequest"){
			request.AddString("eventKey", "getPlayerOfflineFriends");
		}
	}
	
	public class LogChallengeEventRequest_getPlayerOfflineFriends : GSTypedRequest<LogChallengeEventRequest_getPlayerOfflineFriends, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_getPlayerOfflineFriends() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "getPlayerOfflineFriends");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_getPlayerOfflineFriends SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_getPlayerOnlineFriends : GSTypedRequest<LogEventRequest_getPlayerOnlineFriends, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_getPlayerOnlineFriends() : base("LogEventRequest"){
			request.AddString("eventKey", "getPlayerOnlineFriends");
		}
	}
	
	public class LogChallengeEventRequest_getPlayerOnlineFriends : GSTypedRequest<LogChallengeEventRequest_getPlayerOnlineFriends, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_getPlayerOnlineFriends() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "getPlayerOnlineFriends");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_getPlayerOnlineFriends SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_GRANT_GEM : GSTypedRequest<LogEventRequest_GRANT_GEM, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_GRANT_GEM() : base("LogEventRequest"){
			request.AddString("eventKey", "GRANT_GEM");
		}
	}
	
	public class LogChallengeEventRequest_GRANT_GEM : GSTypedRequest<LogChallengeEventRequest_GRANT_GEM, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_GRANT_GEM() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "GRANT_GEM");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_GRANT_GEM SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_LOAD_PLAYER : GSTypedRequest<LogEventRequest_LOAD_PLAYER, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_LOAD_PLAYER() : base("LogEventRequest"){
			request.AddString("eventKey", "LOAD_PLAYER");
		}
	}
	
	public class LogChallengeEventRequest_LOAD_PLAYER : GSTypedRequest<LogChallengeEventRequest_LOAD_PLAYER, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_LOAD_PLAYER() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "LOAD_PLAYER");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_LOAD_PLAYER SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_multi_event_click : GSTypedRequest<LogEventRequest_multi_event_click, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_multi_event_click() : base("LogEventRequest"){
			request.AddString("eventKey", "multi_event_click");
		}
		public LogEventRequest_multi_event_click Set_multi_click( long value )
		{
			request.AddNumber("multi_click", value);
			return this;
		}			
		public LogEventRequest_multi_event_click Set_time_click( long value )
		{
			request.AddNumber("time_click", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_multi_event_click : GSTypedRequest<LogChallengeEventRequest_multi_event_click, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_multi_event_click() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "multi_event_click");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_multi_event_click SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_multi_event_click Set_multi_click( long value )
		{
			request.AddNumber("multi_click", value);
			return this;
		}			
		public LogChallengeEventRequest_multi_event_click Set_time_click( long value )
		{
			request.AddNumber("time_click", value);
			return this;
		}			
	}
	
	public class LogEventRequest_SAVE_PLAYER : GSTypedRequest<LogEventRequest_SAVE_PLAYER, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SAVE_PLAYER() : base("LogEventRequest"){
			request.AddString("eventKey", "SAVE_PLAYER");
		}
		public LogEventRequest_SAVE_PLAYER Set_XP( long value )
		{
			request.AddNumber("XP", value);
			return this;
		}			
		
		public LogEventRequest_SAVE_PLAYER Set_POS( string value )
		{
			request.AddString("POS", value);
			return this;
		}
		public LogEventRequest_SAVE_PLAYER Set_GOLD( long value )
		{
			request.AddNumber("GOLD", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_SAVE_PLAYER : GSTypedRequest<LogChallengeEventRequest_SAVE_PLAYER, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SAVE_PLAYER() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SAVE_PLAYER");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SAVE_PLAYER SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_SAVE_PLAYER Set_XP( long value )
		{
			request.AddNumber("XP", value);
			return this;
		}			
		public LogChallengeEventRequest_SAVE_PLAYER Set_POS( string value )
		{
			request.AddString("POS", value);
			return this;
		}
		public LogChallengeEventRequest_SAVE_PLAYER Set_GOLD( long value )
		{
			request.AddNumber("GOLD", value);
			return this;
		}			
	}
	
	public class LogEventRequest_SUBMIT_SCORE : GSTypedRequest<LogEventRequest_SUBMIT_SCORE, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SUBMIT_SCORE() : base("LogEventRequest"){
			request.AddString("eventKey", "SUBMIT_SCORE");
		}
		public LogEventRequest_SUBMIT_SCORE Set_SCORE( long value )
		{
			request.AddNumber("SCORE", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_SUBMIT_SCORE : GSTypedRequest<LogChallengeEventRequest_SUBMIT_SCORE, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SUBMIT_SCORE() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SUBMIT_SCORE");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SUBMIT_SCORE SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_SUBMIT_SCORE Set_SCORE( long value )
		{
			request.AddNumber("SCORE", value);
			return this;
		}			
	}
	
	public class LogEventRequest_CURRENCY_SUB : GSTypedRequest<LogEventRequest_CURRENCY_SUB, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_CURRENCY_SUB() : base("LogEventRequest"){
			request.AddString("eventKey", "CURRENCY_SUB");
		}
		public LogEventRequest_CURRENCY_SUB Set_ELIXIRE_CURR( long value )
		{
			request.AddNumber("ELIXIRE_CURR", value);
			return this;
		}			
		public LogEventRequest_CURRENCY_SUB Set_GEM_CURR( long value )
		{
			request.AddNumber("GEM_CURR", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_CURRENCY_SUB : GSTypedRequest<LogChallengeEventRequest_CURRENCY_SUB, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_CURRENCY_SUB() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "CURRENCY_SUB");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_CURRENCY_SUB SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_CURRENCY_SUB Set_ELIXIRE_CURR( long value )
		{
			request.AddNumber("ELIXIRE_CURR", value);
			return this;
		}			
		public LogChallengeEventRequest_CURRENCY_SUB Set_GEM_CURR( long value )
		{
			request.AddNumber("GEM_CURR", value);
			return this;
		}			
	}
	
	public class LogEventRequest_updatePlayerInfo : GSTypedRequest<LogEventRequest_updatePlayerInfo, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_updatePlayerInfo() : base("LogEventRequest"){
			request.AddString("eventKey", "updatePlayerInfo");
		}
		
		public LogEventRequest_updatePlayerInfo Set_userName( string value )
		{
			request.AddString("userName", value);
			return this;
		}
		
		public LogEventRequest_updatePlayerInfo Set_displayName( string value )
		{
			request.AddString("displayName", value);
			return this;
		}
		
		public LogEventRequest_updatePlayerInfo Set_country( string value )
		{
			request.AddString("country", value);
			return this;
		}
		
		public LogEventRequest_updatePlayerInfo Set_city( string value )
		{
			request.AddString("city", value);
			return this;
		}
		public LogEventRequest_updatePlayerInfo Set_level( long value )
		{
			request.AddNumber("level", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_updatePlayerInfo : GSTypedRequest<LogChallengeEventRequest_updatePlayerInfo, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_updatePlayerInfo() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "updatePlayerInfo");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_updatePlayerInfo SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_updatePlayerInfo Set_userName( string value )
		{
			request.AddString("userName", value);
			return this;
		}
		public LogChallengeEventRequest_updatePlayerInfo Set_displayName( string value )
		{
			request.AddString("displayName", value);
			return this;
		}
		public LogChallengeEventRequest_updatePlayerInfo Set_country( string value )
		{
			request.AddString("country", value);
			return this;
		}
		public LogChallengeEventRequest_updatePlayerInfo Set_city( string value )
		{
			request.AddString("city", value);
			return this;
		}
		public LogChallengeEventRequest_updatePlayerInfo Set_level( long value )
		{
			request.AddNumber("level", value);
			return this;
		}			
	}
	
}
	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_divisionSpecificLeaderboard : GSTypedRequest<LeaderboardDataRequest_divisionSpecificLeaderboard,LeaderboardDataResponse_divisionSpecificLeaderboard>
	{
		public LeaderboardDataRequest_divisionSpecificLeaderboard() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "divisionSpecificLeaderboard");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_divisionSpecificLeaderboard (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_divisionSpecificLeaderboard SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_divisionSpecificLeaderboard SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_divisionSpecificLeaderboard SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_divisionSpecificLeaderboard SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_divisionSpecificLeaderboard SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_divisionSpecificLeaderboard SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_divisionSpecificLeaderboard SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_divisionSpecificLeaderboard SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_divisionSpecificLeaderboard SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_divisionSpecificLeaderboard : GSTypedRequest<AroundMeLeaderboardRequest_divisionSpecificLeaderboard,AroundMeLeaderboardResponse_divisionSpecificLeaderboard>
	{
		public AroundMeLeaderboardRequest_divisionSpecificLeaderboard() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "divisionSpecificLeaderboard");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_divisionSpecificLeaderboard (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_divisionSpecificLeaderboard SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_divisionSpecificLeaderboard SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_divisionSpecificLeaderboard SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_divisionSpecificLeaderboard SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_divisionSpecificLeaderboard SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_divisionSpecificLeaderboard SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_divisionSpecificLeaderboard SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_divisionSpecificLeaderboard : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_divisionSpecificLeaderboard(GSData data) : base(data){}
		public long? score{
			get{return response.GetNumber("score");}
		}
		public long? division{
			get{return response.GetNumber("division");}
		}
		public string league{
			get{return response.GetString("league");}
		}
	}
	
	public class LeaderboardDataResponse_divisionSpecificLeaderboard : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_divisionSpecificLeaderboard(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_divisionSpecificLeaderboard> Data_divisionSpecificLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_divisionSpecificLeaderboard>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_divisionSpecificLeaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_divisionSpecificLeaderboard> First_divisionSpecificLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_divisionSpecificLeaderboard>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_divisionSpecificLeaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_divisionSpecificLeaderboard> Last_divisionSpecificLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_divisionSpecificLeaderboard>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_divisionSpecificLeaderboard(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_divisionSpecificLeaderboard : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_divisionSpecificLeaderboard(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_divisionSpecificLeaderboard> Data_divisionSpecificLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_divisionSpecificLeaderboard>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_divisionSpecificLeaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_divisionSpecificLeaderboard> First_divisionSpecificLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_divisionSpecificLeaderboard>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_divisionSpecificLeaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_divisionSpecificLeaderboard> Last_divisionSpecificLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_divisionSpecificLeaderboard>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_divisionSpecificLeaderboard(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_GlobalLeagueLeaderboard : GSTypedRequest<LeaderboardDataRequest_GlobalLeagueLeaderboard,LeaderboardDataResponse_GlobalLeagueLeaderboard>
	{
		public LeaderboardDataRequest_GlobalLeagueLeaderboard() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "GlobalLeagueLeaderboard");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_GlobalLeagueLeaderboard (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_GlobalLeagueLeaderboard SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_GlobalLeagueLeaderboard SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_GlobalLeagueLeaderboard SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_GlobalLeagueLeaderboard SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_GlobalLeagueLeaderboard SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_GlobalLeagueLeaderboard SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_GlobalLeagueLeaderboard SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_GlobalLeagueLeaderboard SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_GlobalLeagueLeaderboard SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_GlobalLeagueLeaderboard : GSTypedRequest<AroundMeLeaderboardRequest_GlobalLeagueLeaderboard,AroundMeLeaderboardResponse_GlobalLeagueLeaderboard>
	{
		public AroundMeLeaderboardRequest_GlobalLeagueLeaderboard() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "GlobalLeagueLeaderboard");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_GlobalLeagueLeaderboard (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_GlobalLeagueLeaderboard SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_GlobalLeagueLeaderboard SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_GlobalLeagueLeaderboard SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_GlobalLeagueLeaderboard SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_GlobalLeagueLeaderboard SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_GlobalLeagueLeaderboard SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_GlobalLeagueLeaderboard SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_GlobalLeagueLeaderboard : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_GlobalLeagueLeaderboard(GSData data) : base(data){}
		public long? score{
			get{return response.GetNumber("score");}
		}
		public string league{
			get{return response.GetString("league");}
		}
	}
	
	public class LeaderboardDataResponse_GlobalLeagueLeaderboard : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_GlobalLeagueLeaderboard(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_GlobalLeagueLeaderboard> Data_GlobalLeagueLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_GlobalLeagueLeaderboard>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_GlobalLeagueLeaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_GlobalLeagueLeaderboard> First_GlobalLeagueLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_GlobalLeagueLeaderboard>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_GlobalLeagueLeaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_GlobalLeagueLeaderboard> Last_GlobalLeagueLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_GlobalLeagueLeaderboard>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_GlobalLeagueLeaderboard(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_GlobalLeagueLeaderboard : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_GlobalLeagueLeaderboard(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_GlobalLeagueLeaderboard> Data_GlobalLeagueLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_GlobalLeagueLeaderboard>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_GlobalLeagueLeaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_GlobalLeagueLeaderboard> First_GlobalLeagueLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_GlobalLeagueLeaderboard>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_GlobalLeagueLeaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_GlobalLeagueLeaderboard> Last_GlobalLeagueLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_GlobalLeagueLeaderboard>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_GlobalLeagueLeaderboard(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_SCORE_LEADERBOARD : GSTypedRequest<LeaderboardDataRequest_SCORE_LEADERBOARD,LeaderboardDataResponse_SCORE_LEADERBOARD>
	{
		public LeaderboardDataRequest_SCORE_LEADERBOARD() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "SCORE_LEADERBOARD");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_SCORE_LEADERBOARD (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_SCORE_LEADERBOARD SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_SCORE_LEADERBOARD SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_SCORE_LEADERBOARD SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_SCORE_LEADERBOARD SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_SCORE_LEADERBOARD SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_SCORE_LEADERBOARD SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_SCORE_LEADERBOARD SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_SCORE_LEADERBOARD SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_SCORE_LEADERBOARD SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_SCORE_LEADERBOARD : GSTypedRequest<AroundMeLeaderboardRequest_SCORE_LEADERBOARD,AroundMeLeaderboardResponse_SCORE_LEADERBOARD>
	{
		public AroundMeLeaderboardRequest_SCORE_LEADERBOARD() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "SCORE_LEADERBOARD");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_SCORE_LEADERBOARD (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_SCORE_LEADERBOARD SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_SCORE_LEADERBOARD SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_SCORE_LEADERBOARD SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_SCORE_LEADERBOARD SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_SCORE_LEADERBOARD SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_SCORE_LEADERBOARD SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_SCORE_LEADERBOARD SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_SCORE_LEADERBOARD : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_SCORE_LEADERBOARD(GSData data) : base(data){}
		public long? SCORE{
			get{return response.GetNumber("SCORE");}
		}
	}
	
	public class LeaderboardDataResponse_SCORE_LEADERBOARD : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_SCORE_LEADERBOARD(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_SCORE_LEADERBOARD> Data_SCORE_LEADERBOARD{
			get{return new GSEnumerable<_LeaderboardEntry_SCORE_LEADERBOARD>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_SCORE_LEADERBOARD(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_SCORE_LEADERBOARD> First_SCORE_LEADERBOARD{
			get{return new GSEnumerable<_LeaderboardEntry_SCORE_LEADERBOARD>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_SCORE_LEADERBOARD(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_SCORE_LEADERBOARD> Last_SCORE_LEADERBOARD{
			get{return new GSEnumerable<_LeaderboardEntry_SCORE_LEADERBOARD>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_SCORE_LEADERBOARD(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_SCORE_LEADERBOARD : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_SCORE_LEADERBOARD(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_SCORE_LEADERBOARD> Data_SCORE_LEADERBOARD{
			get{return new GSEnumerable<_LeaderboardEntry_SCORE_LEADERBOARD>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_SCORE_LEADERBOARD(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_SCORE_LEADERBOARD> First_SCORE_LEADERBOARD{
			get{return new GSEnumerable<_LeaderboardEntry_SCORE_LEADERBOARD>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_SCORE_LEADERBOARD(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_SCORE_LEADERBOARD> Last_SCORE_LEADERBOARD{
			get{return new GSEnumerable<_LeaderboardEntry_SCORE_LEADERBOARD>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_SCORE_LEADERBOARD(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_LB_CO : GSTypedRequest<LeaderboardDataRequest_LB_CO,LeaderboardDataResponse_LB_CO>
	{
		public LeaderboardDataRequest_LB_CO() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "LB_CO");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_LB_CO (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_LB_CO SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_LB_CO SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_LB_CO SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_LB_CO SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_LB_CO SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_LB_CO SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_LB_CO SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_LB_CO SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_LB_CO SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_LB_CO : GSTypedRequest<AroundMeLeaderboardRequest_LB_CO,AroundMeLeaderboardResponse_LB_CO>
	{
		public AroundMeLeaderboardRequest_LB_CO() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "LB_CO");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_LB_CO (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_LB_CO SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_LB_CO SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_LB_CO SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_LB_CO SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_LB_CO SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_LB_CO SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_LB_CO SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_LB_CO : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_LB_CO(GSData data) : base(data){}
		public long? AT_LB_LVL{
			get{return response.GetNumber("AT_LB_LVL");}
		}
		public string AT_LB_CO{
			get{return response.GetString("AT_LB_CO");}
		}
	}
	
	public class LeaderboardDataResponse_LB_CO : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_LB_CO(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_LB_CO> Data_LB_CO{
			get{return new GSEnumerable<_LeaderboardEntry_LB_CO>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_LB_CO(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB_CO> First_LB_CO{
			get{return new GSEnumerable<_LeaderboardEntry_LB_CO>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_LB_CO(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB_CO> Last_LB_CO{
			get{return new GSEnumerable<_LeaderboardEntry_LB_CO>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_LB_CO(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_LB_CO : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_LB_CO(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_LB_CO> Data_LB_CO{
			get{return new GSEnumerable<_LeaderboardEntry_LB_CO>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_LB_CO(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB_CO> First_LB_CO{
			get{return new GSEnumerable<_LeaderboardEntry_LB_CO>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_LB_CO(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB_CO> Last_LB_CO{
			get{return new GSEnumerable<_LeaderboardEntry_LB_CO>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_LB_CO(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_LB_TEAM : GSTypedRequest<LeaderboardDataRequest_LB_TEAM,LeaderboardDataResponse_LB_TEAM>
	{
		public LeaderboardDataRequest_LB_TEAM() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "LB_TEAM");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_LB_TEAM (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_LB_TEAM SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_LB_TEAM SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_LB_TEAM SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_LB_TEAM SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_LB_TEAM SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_LB_TEAM SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_LB_TEAM SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_LB_TEAM SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_LB_TEAM SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_LB_TEAM : GSTypedRequest<AroundMeLeaderboardRequest_LB_TEAM,AroundMeLeaderboardResponse_LB_TEAM>
	{
		public AroundMeLeaderboardRequest_LB_TEAM() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "LB_TEAM");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_LB_TEAM (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_LB_TEAM SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_LB_TEAM SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_LB_TEAM SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_LB_TEAM SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_LB_TEAM SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_LB_TEAM SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_LB_TEAM SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_LB_TEAM : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_LB_TEAM(GSData data) : base(data){}
		public long? SUM_ATT_LVL_TEAM{
			get{return response.GetNumber("SUM-ATT_LVL_TEAM");}
		}
	}
	
	public class LeaderboardDataResponse_LB_TEAM : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_LB_TEAM(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_LB_TEAM> Data_LB_TEAM{
			get{return new GSEnumerable<_LeaderboardEntry_LB_TEAM>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_LB_TEAM(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB_TEAM> First_LB_TEAM{
			get{return new GSEnumerable<_LeaderboardEntry_LB_TEAM>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_LB_TEAM(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB_TEAM> Last_LB_TEAM{
			get{return new GSEnumerable<_LeaderboardEntry_LB_TEAM>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_LB_TEAM(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_LB_TEAM : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_LB_TEAM(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_LB_TEAM> Data_LB_TEAM{
			get{return new GSEnumerable<_LeaderboardEntry_LB_TEAM>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_LB_TEAM(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB_TEAM> First_LB_TEAM{
			get{return new GSEnumerable<_LeaderboardEntry_LB_TEAM>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_LB_TEAM(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB_TEAM> Last_LB_TEAM{
			get{return new GSEnumerable<_LeaderboardEntry_LB_TEAM>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_LB_TEAM(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_LB_XP_GL : GSTypedRequest<LeaderboardDataRequest_LB_XP_GL,LeaderboardDataResponse_LB_XP_GL>
	{
		public LeaderboardDataRequest_LB_XP_GL() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "LB_XP_GL");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_LB_XP_GL (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_LB_XP_GL SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_LB_XP_GL SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_LB_XP_GL SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_LB_XP_GL SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_LB_XP_GL SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_LB_XP_GL SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_LB_XP_GL SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_LB_XP_GL SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_LB_XP_GL SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_LB_XP_GL : GSTypedRequest<AroundMeLeaderboardRequest_LB_XP_GL,AroundMeLeaderboardResponse_LB_XP_GL>
	{
		public AroundMeLeaderboardRequest_LB_XP_GL() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "LB_XP_GL");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_LB_XP_GL (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_LB_XP_GL SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_LB_XP_GL SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_LB_XP_GL SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_LB_XP_GL SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_LB_XP_GL SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_LB_XP_GL SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_LB_XP_GL SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_LB_XP_GL : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_LB_XP_GL(GSData data) : base(data){}
		public long? AT_XP_LB_GL{
			get{return response.GetNumber("AT_XP_LB_GL");}
		}
	}
	
	public class LeaderboardDataResponse_LB_XP_GL : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_LB_XP_GL(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_LB_XP_GL> Data_LB_XP_GL{
			get{return new GSEnumerable<_LeaderboardEntry_LB_XP_GL>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_LB_XP_GL(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB_XP_GL> First_LB_XP_GL{
			get{return new GSEnumerable<_LeaderboardEntry_LB_XP_GL>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_LB_XP_GL(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB_XP_GL> Last_LB_XP_GL{
			get{return new GSEnumerable<_LeaderboardEntry_LB_XP_GL>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_LB_XP_GL(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_LB_XP_GL : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_LB_XP_GL(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_LB_XP_GL> Data_LB_XP_GL{
			get{return new GSEnumerable<_LeaderboardEntry_LB_XP_GL>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_LB_XP_GL(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB_XP_GL> First_LB_XP_GL{
			get{return new GSEnumerable<_LeaderboardEntry_LB_XP_GL>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_LB_XP_GL(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB_XP_GL> Last_LB_XP_GL{
			get{return new GSEnumerable<_LeaderboardEntry_LB_XP_GL>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_LB_XP_GL(data);});}
		}
	}
}	

namespace GameSparks.Api.Messages {

		public class ScriptMessage_friendOfflineMessage : ScriptMessage {
		
			public new static Action<ScriptMessage_friendOfflineMessage> Listener;
	
			public ScriptMessage_friendOfflineMessage(GSData data) : base(data){}
	
			private static ScriptMessage_friendOfflineMessage Create(GSData data)
			{
				ScriptMessage_friendOfflineMessage message = new ScriptMessage_friendOfflineMessage (data);
				return message;
			}
	
			static ScriptMessage_friendOfflineMessage()
			{
				handlers.Add (".ScriptMessage_friendOfflineMessage", Create);
	
			}
			
			override public void NotifyListeners()
			{
				if (Listener != null)
				{
					Listener (this);
				}
			}
		}
		public class ScriptMessage_friendOnlineMessage : ScriptMessage {
		
			public new static Action<ScriptMessage_friendOnlineMessage> Listener;
	
			public ScriptMessage_friendOnlineMessage(GSData data) : base(data){}
	
			private static ScriptMessage_friendOnlineMessage Create(GSData data)
			{
				ScriptMessage_friendOnlineMessage message = new ScriptMessage_friendOnlineMessage (data);
				return message;
			}
	
			static ScriptMessage_friendOnlineMessage()
			{
				handlers.Add (".ScriptMessage_friendOnlineMessage", Create);
	
			}
			
			override public void NotifyListeners()
			{
				if (Listener != null)
				{
					Listener (this);
				}
			}
		}
		public class ScriptMessage_friendRequestMessage : ScriptMessage {
		
			public new static Action<ScriptMessage_friendRequestMessage> Listener;
	
			public ScriptMessage_friendRequestMessage(GSData data) : base(data){}
	
			private static ScriptMessage_friendRequestMessage Create(GSData data)
			{
				ScriptMessage_friendRequestMessage message = new ScriptMessage_friendRequestMessage (data);
				return message;
			}
	
			static ScriptMessage_friendRequestMessage()
			{
				handlers.Add (".ScriptMessage_friendRequestMessage", Create);
	
			}
			
			override public void NotifyListeners()
			{
				if (Listener != null)
				{
					Listener (this);
				}
			}
		}

}
