package com.impulsfp.mobile.network

/**
 * LOGIN SERVER
 */

//Request que s'envia al servidor
data class LoginRequest(
    val username: String,
    val password: String
)

//Resposta correcta del servidor
data class LoginResponse(
    val sessionId: String,
    val userType: String
)

//Resposta d'error
data class ErrorResponse(
    val error: String
)

/**
 * LOGOUT SERVER
 */

//Request logout
data class LogoutRequest(
    val sessionId: String
)

//Resposta correcta logout
data class LogoutResponse(
    val message: String
)