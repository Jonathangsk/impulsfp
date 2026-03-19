package com.impulsfp.mobile.network

import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

/**
 * Objecte encarregat de configurar Retrofit i proporcionar
 * les instàncies dels serveis de xarxa de l'aplicació
 */

object ApiClient {

    /**
     * URL base del servidor provisional
     */
    private const val BASE_URL = "http://10.0.2.2:8080/"

    /**
     * Instància única de Retrofit configurada amb:
     * -URL base del servidor
     * -conversor Gson per transformar JSON en objectes Kotlin
     */
    private val retrofit: Retrofit by lazy {
        Retrofit.Builder()
            .baseUrl(BASE_URL)
            .addConverterFactory(GsonConverterFactory.create())
            .build()
    }

    /**
     * Servei d'autenticació utilitzat per fer les peticions
     * de login i logout al servidor
     */
    val authApiService: AuthApiService by lazy {
        retrofit.create(AuthApiService::class.java)
    }
}