Shader "Custom/alpha1" {

	Properties{
		_MainTex("Color (RGB)", 2D) = "white"
	}

		SubShader{
		Tags{ "Queue" = "Transparent" "RenderType" = "Transparent" }

		CGPROGRAM
#pragma surface surf NoLighting alpha 

		fixed4 LightingNoLighting(SurfaceOutput s, fixed3 lightDir, fixed atten) {
		fixed4 c;
		c.rgb = s.Albedo;
		c.a = s.Alpha;
		return c;
	}

	struct Input {
		float2 uv_MainTex;
	};

	sampler2D _MainTex;

	void surf(Input IN, inout SurfaceOutput o) {
		o.Albedo = tex2D(_MainTex, IN.uv_MainTex).rgb;
		o.Alpha = min(o.Albedo.r + o.Albedo.g + o.Albedo.b, 1) * 0.5;
	}

	ENDCG
	}

}
