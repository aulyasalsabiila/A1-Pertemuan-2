#version 330 core

// in vec4 position;

// Output data
in vec3 color; // Receive color from vertex shader
out vec4 FragColor;

void main() {

	// Output color = color of the texture at the specified UV
	// color = vec4(gl_FragCoord., 0, 1); //vec4(1., 0., 0., 1.);
	FragColor = vec4(color, 1.0); // Set fragment color from the input
	// color = vec4(gl_FrontFacing, gl_FrontFacing, gl_FrontFacing, gl_FrontFacing);
}