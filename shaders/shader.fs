#version 330 core
out vec4 FragColor;  
in vec3 ourColor;
  
void main()
{
    //FragColor = vec4(ourColor, 1.0);
    FragColor = vec4(ourColor.r, 0.5f, 0.2f, 1.0f);
}