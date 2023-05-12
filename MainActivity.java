package com.example.messagedisplay;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        EditText Name1 = findViewById(R.id.Name1);
        EditText Name2 = findViewById(R.id.Name2);
        Button swapBtn = findViewById(R.id.swapBtn);
        Button checkBtn = findViewById(R.id.checkBtn);

        swapBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String name1 = Name1.getText().toString();
                String name2 = Name2.getText().toString();

                Name1.setText(name2);
                Name2.setText(name1);
            }
        });
        checkBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String name1 = Name1.getText().toString();
                String name2 = Name2.getText().toString();

                String Message = "";
                if (name1.equals(name2)) {
                    Message = "SAME";
                }
                else{
                    Message = "NOT THE SAME";
                }
                Intent intent = new Intent(MainActivity.this, MessageDisplay.class);
                intent.putExtra("output", Message);
                startActivity(intent);
            }
        });
    };

}