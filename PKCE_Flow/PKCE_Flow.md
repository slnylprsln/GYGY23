# PKCE Flow

PKCE (Proof Key for Code Exchange), CSRF (Cross-Site Request Forgery) ve Authorization Code Injection saldırılarını önlemeyi görev edinen bir Authorization Code Flow uzantısıdır. PKCE başlangıçta mobil uygulamalardaki yetkilendirme kodu akışını korumak için tasarlanmıştır, ancak yetkilendirme kodu enjeksiyonunu önleme yeteneği, onu her tür OAuth istemcisi için, hatta istemci kimlik doğrulaması kullanan web uygulamaları için kullanışlı kılar. 

PKCE ve Authorization Code Flow arasındaki temel fark, PKCE ile akışta client sırrının gerekli olmamasıdır. 

## Nasıl Çalışır?

![auth-sequence-auth-code-pkce](https://github.com/slnylprsln/Turkcell-GYGY23/assets/56932572/78894561-64de-4b65-a74c-4a1db6d6b4cc)


 **1.** Kullanıcı, uygulama içinde oturum açar. 
 
 **2.** Auth0'ın SDK'sı, kriptografik olarak rasgele bir code_verifier oluşturur ve bundan bir code_challenge oluşturur. 
 
 **3.** Auth0'ın SDK'sı, code_challenge ile birlikte kullanıcıyı Auth0 Yetkilendirme Sunucusuna yönlendirir (/authorize
endpoint). 

**4.** Auth0 Yetkilendirme Sunucunuz, kullanıcıyı oturum açma ve yetkilendirme istemine yönlendirir. 

**5.** Kullanıcı, yapılandırılmış oturum açma seçeneklerinden birini kullanarak kimlik doğrulaması yapar ve Auth0'ın uygulamaya vereceği izinlerin listelendiği bir izin sayfası görebilir. 

**6.** Auth0 Yetkilendirme Sunucunuz code_challenge'ı saklar ve kullanıcıyı bir yetkilendirme koduyla uygulamaya geri yönlendirir, bu tek kullanım için uygundur. 

**7.** Auth0'ın SDK'sı bu kodu ve code_verifier'ı (2. adımda oluşturulan) Auth0 Yetkilendirme Sunucusuna gönderir (
/oauth/token
endpoint). 

**8.** Auth0 Yetkilendirme Sunucunuz code_challenge ve code_verifier'ı doğrular. 

**9.** Auth0 Yetkilendirme Sunucunuz, bir kimlik belirteci ve erişim belirteci (ve isteğe bağlı olarak bir yenileme belirteci) ile yanıt verir. 

**10.** Uygulamanız, kullanıcı hakkındaki bilgilere erişmek üzere bir API'yi çağırmak için erişim belirtecini kullanabilir. 

**11.** API, istenen verilerle yanıt verir. 

