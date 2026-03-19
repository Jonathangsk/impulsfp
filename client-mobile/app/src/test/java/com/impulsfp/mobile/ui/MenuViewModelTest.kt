package com.impulsfp.mobile.ui

import com.impulsfp.mobile.data.SessionData
import com.impulsfp.mobile.data.User
import org.junit.After
import org.junit.Test
import kotlin.test.assertFalse
import kotlin.test.assertNull
import kotlin.test.assertTrue


/**
 * Tests unitaris del ViewModel del menú.
 * Verifiquen que el procés de logout:
 * - neteja la sessió local
 * - executa l'acció final indicada
 */
class MenuViewModelTest {

    @After
    fun tearDown() {
        SessionData.logout()
    }

    @Test
    fun logout_clean_session_and_calls_onFinished() {
        SessionData.currentUser = User(
            username = "empresa",
            role = "EMPRESA",
            sessionId = "session-456"
        )

        val viewModel = MenuViewModel()
        var onFinishedCalled = false

        viewModel.logout {
            onFinishedCalled = true
        }

        assertNull(SessionData.currentUser)
        assertFalse(SessionData.isLoggedIn())
        assertTrue(onFinishedCalled)
    }
}