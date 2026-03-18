package com.impulsfp.server.controller;

import com.impulsfp.server.dto.LoginRequestDto;
import com.impulsfp.server.dto.LoginResponseDto;
import com.impulsfp.server.service.AuthService;
import com.impulsfp.server.session.SessionManager;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;


/**
 * Controlador REST que gestiona les peticions d'autenticació dels usuaris; proporciona la lògica i els endpoints per iniciar i finalitzar sessió.
 */
@RestController
@RequestMapping("/auth")
public class AuthController {

    private final AuthService authService;

    public AuthController(AuthService authService) {
        this.authService = authService;
    }

    /**
     * Endpoint per iniciar sessió; rep un objecte JSON amb el nom d'usuari i la contrasenya, i retorna un objecte JSON
     * amb l'identificador de sessió i el tipus d'usuari si les credencials són correctes. Si no, retorna un error 401
     * @param request
     * @return
     */
    @PostMapping("/login")
    public ResponseEntity<?> login(@RequestBody LoginRequestDto request){

        LoginResponseDto response = authService.login(request.getUsername(), request.getPassword()); //el servei d'autenticació verifica les credencials i retorna un objecte de resposta amb les dades de sessió (sessionId i userType) si són correctes
        if(response == null){ //si les credencials no són correctes, el servei retorna null
            return ResponseEntity.status(401)
                    .body("{\"error\":\"Usuari o contrasenya incorrectes\"}");
        }

        return ResponseEntity.ok(response);
    }

    /**
     * Endpoint per finalitzar sessió; rep un identificador de sessió com a paràmetre i elimina la sessió corresponent. Si el
     * identificador de sessió no és vàlid, retorna un error 401
     * @param sessionId
     * @return
     */
    @PostMapping("/logout")
    public ResponseEntity<?> logout(@RequestParam String sessionId){

        if(!SessionManager.isValid(sessionId)){ //verifica que el sessionId proporcionat és vàlid; si no ho és, retorna un error 401
            return ResponseEntity.status(401)
                    .body("{\"error\":\"Sessió no vàlida\"}");
        }

        SessionManager.removeSession(sessionId); //si el sessionId és vàlid, elimina la sessió corresponent i retorna un missatge de confirmació

        return ResponseEntity.ok("{\"message\":\"Sessió finalitzada correctament\"}");
    }

    /**
     * Endpoint per gestionar les peticions GET a /auth/login; informa que encara no accepta peticions GET
     * @return
     */
    @GetMapping("/login")
    public String missatgeErrorGet(){
        return "{\"error\":\"Aquest endpoint no accepta peticions GET\"}";
    }
}