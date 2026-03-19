package com.impulsfp.mobile.data

/**
 * Model que representa un usuari autenticat a l'aplicació.
 * Conté la informació bàsica de l'usuari: nom d'usuari, sessionId i role
 */

data class User(
    val username: String,
    val role: String,
    val sessionId: String
)
