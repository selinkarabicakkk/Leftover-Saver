

package com.example.foodleftoversaver

import android.content.Intent
import android.os.Bundle
import android.os.Handler
import android.view.WindowManager.LayoutParams.*
import androidx.appcompat.app.AppCompatActivity


class SplashActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        window.setFlags(
            FLAG_FULLSCREEN,
            FLAG_FULLSCREEN
        )

        setContentView(R.layout.activity_splash)
        android.os.Handler().postDelayed(
        {
            val intent=Intent(this@SplashActivity,SignInActivity::class.java)
            startActivity(intent)
            finish()
        }, SPLASH_TIMER.toLong()
        )

    }
    companion object{
        private const val SPLASH_TIMER=3000
    }

}
