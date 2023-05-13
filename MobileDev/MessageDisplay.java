package com.example.messagedisplay;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.widget.TextView;
public class MessageDisplay extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_display_message);

        TextView output = findViewById(R.id.output);
        Intent intent = getIntent();
        String Message = intent.getStringExtra("output");
        output.setText(Message);
    }
}
