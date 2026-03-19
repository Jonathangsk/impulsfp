package com.impulsfp.mobile.network

import retrofit2.Response
import retrofit2.http.POST
import retrofit2.http.Body

/**
 * Interfície que defineix les crides HTTP relacionades amb l'autenticació
 *
 * Aquesta classe és utilitzada per Retrofit per generar automàticament
 * la implementació que farà les peticions al servidor.
 *
 * Endpoints disponibles:
 * -POST /auth/login
 * -POST /auth/logout
 */


interface AuthApiService {

    /**
     * Envia una petició de login al servidor.
     * Endpoint:
     * POST /auth/login
     *
     * @param request conté el username i la password que envia el client.
     * @return Response<LoginResponse>
     *     Si la petició és correcta contindrà:
     *     - sessionId
     *     - userType
     */
    @POST("auth/login")
    suspend fun login(
        @Body request: LoginRequest
    ): Response<LoginResponse>

    /**
     * Envia una petició per tancar la sessió d'un usuari autenticat
     * Endpoint:
     * POST /auth/logout
     *
     * @param request conté el sessionId que identifica la sessió activa.
     * @return Response<LogoutResponse>
     *     Si la petició és correcta retornarà un missatge indicant
     *     que la sessió s'ha tancat correctament.
     */
    @POST("auth/logout")
    suspend fun logout(
        @Body request: LogoutRequest
    ): Response<LogoutResponse>
}