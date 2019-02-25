---?color=#F2EBE6&image=template/img/umb/heart1.png&size=160px 160px&position=center

---?color=#3544B1
@title[Introduction]

## Building Packages with Umbraco 8

@snap[south span-100 text-07]
Shannon Deminick&nbsp;&nbsp;|&nbsp;&nbsp; @css[text-umb-pink](twitter): @shazwazza&nbsp;&nbsp;|&nbsp;&nbsp;@css[text-umb-pink](web): shazwazza.com
@snapend

---?color=#3544B1
@title[Agenda]

## Migrating&hellip;<br/>Building&hellip;<br/>Packaging&hellip;<br/>@css[text-umb-pink](Learning!)

---?color=#F2EBE6

@title[Articulate]

@snap[west]
@img[split-screen-img span-80](template/img/umb/articulate.png)
@snapend

@snap[north-east text-20 text-bolder text-umb-blue]
Articulate
@snapend

@snap[east]
@ul[text-umb-dark-blue]
- Uses a __lot__ of Umbraco surface area
- A good way to test v8!
@olend
@snapend

---?color=#F2EBE6

@title[Surface Area]

@snap[west]
@img[split-screen-img span-80](template/img/umb/articulate.png)
@snapend

@snap[east]
@ul[text-umb-dark-blue]
- Custom routes & controllers
- Virtual nodes
- Content finders
- Event handlers
- Dashboards
- Property Editors
- Package manifest
- Lots of views
- Custom searching
- Custom DB queries
@olend
@snapend

---?color=#3544B1

@title[Migrating]

@snap[midpoint span-100 text-15]
## Migrating
@snapend

---?color=#3544B1

@snap[west span-45]
# MVC
@snapend

@snap[north-east span-60]
@box[bg-umb-grey text-umb-dark-blue rounded](Model# Published content and getting property values)
@snapend

@snap[east span-60]
@box[bg-umb-grey text-umb-dark-blue rounded](View# APIs available in Razor views)
@snapend

@snap[south-east span-60]
@box[bg-umb-grey text-umb-dark-blue rounded](Controller# Changes to controllers and how to create your own)
@snapend

---?color=#F2EBE6

@title[Published Content]

@snap[east text-20 text-bold text-umb-blue span-40]
Model changes
@snapend

@snap[west text-umb-dark-blue span-65]
@ul[split-screen-list text-08]
* RenderModel doesn't exist, just IPublishedContent
* One way to get property values
* No more dynamcis
@ulend
@snapend

---?color=#F2EBE6

@title[No RenderModel v7]

@snap[north-east text-umb-brown]
@css[text-umb-blue text-bolder](Page model)(v7)
@snapend

@code[html](template/src/page-model-v7.cshtml)

@[1](Default template header in v7)
@[2-5](UmbracoTemplatePage is really just this)
@[9](RenderModel is the page model)

---?color=#F2EBE6

@title[No RenderModel v8]

@snap[north-east text-umb-brown]
@css[text-umb-blue text-bolder](Page model)(v8)
@snapend

@code[html](template/src/page-model-v8.cshtml)

@[1](Default template header in v8)
@[2-5](UmbracoViewPage is really just this)
@[9](IPublishedContent is the model @fa[smile-o])

---?color=#3544B1

@title[Model.Value?]

@snap[midpoint span-100 text-15]
## @css[text-umb-pink](@Model.Value) ?!
@snapend

---?color=#F2EBE6

@title[Property Values v7]

@snap[north-east text-umb-brown]
@css[text-umb-blue text-bolder](Property values)(v7)
@snapend

@code[html zoom-09](template/src/prop-values-v7.cshtml)

@[2](If you want a recursive value you'd use Umbraco.Field)
@[4](One way to get a value in v7)
@[6](Typical way to get a value in v7)
@[7](Getting a strongly typed value in v7)

---?color=#F2EBE6

@title[Property Values v8]

@snap[north-east text-umb-brown]
@css[text-umb-blue text-bolder](Property values)(v8)
@snapend

@code[html zoom-09](template/src/prop-values-v8.cshtml)

@[2](Model.Value is used)
@[4](Model.Value is used)
@[6](Model.Value is used)
@[7](Model.Value is used)


---?color=#F2EBE6

@title[View APIs Traversal]

@snap[north text-umb-brown]
@css[text-umb-blue text-bolder](View APIs - Traversal)
@snapend

@snap[north-west text-umb-brown]
(v7)
@snapend

@snap[north-east text-umb-brown]
(v8)
@snapend

@snap[west span-50]
@code[cs zoom-08](template/src/view-apis-v7-traverse.cshtml)
@snapend

@snap[east span-50]
@code[cs zoom-08](template/src/view-apis-v8-traverse.cshtml)
@snapend

---?color=#F2EBE6

@title[View APIs Urls]

@snap[north text-umb-brown]
@css[text-umb-blue text-bolder](View APIs - URLs)
@snapend

@snap[north-west text-umb-brown]
(v7)
@snapend

@snap[north-east text-umb-brown]
(v8)
@snapend

@snap[west span-50]
@code[cs zoom-08](template/src/view-apis-v7-urls.cshtml)
@snapend

@snap[east span-50]
@code[cs zoom-08](template/src/view-apis-v8-urls.cshtml)
@snapend

---?color=#F2EBE6

@title[View APIs Lookup]

@snap[north text-umb-brown]
@css[text-umb-blue text-bolder](View APIs - Lookup)
@snapend

@snap[north-west text-umb-brown]
(v7)
@snapend

@snap[north-east text-umb-brown]
(v8)
@snapend

@snap[west span-50]
@code[cs zoom-08](template/src/view-apis-v7-lookup.cshtml)
@snapend

@snap[east span-50]
@code[cs zoom-08](template/src/view-apis-v8-lookup.cshtml)
@snapend

---?color=#3544B1

@title[No dynamics]

@snap[midpoint span-100 text-15]
## ~~&nbsp;@CurrentPage&nbsp;~~
@snapend

---?color=#3544B1

@title[XPath vs Linq]

@snap[midpoint span-100 text-15]
## XPath vs Linq
@snapend
@snap[midpoint span-100]
<br/>
<br/>
<br/>
@css[text-italic text-umb-pink text-08](v8's cache is __objects__, not XML)
@snapend

---?color=#3544B1

@title[Custom Controllers]

@snap[midpoint span-100 text-15]
## Custom Controllers
@snapend
@snap[midpoint span-100]
<br/>
<br/>
<br/>
@css[text-italic text-umb-pink text-08](Actually ... not a lot has changed)
@snapend

---?color=#F2EBE6

@title[Custom Controllers]

@snap[east text-20 text-bold text-umb-blue span-40]
Custom Controllers
@snapend

@snap[west text-umb-dark-blue span-55]
@ul[split-screen-list text-08]
* Typical controllers are still auto routed<br/><br/><small>`SurfaceController`<br/>`UmbracoApiController`</small>
* Controllers are constructed by DI
* Controllers must be registered in the Container
* Typical controllers are auto-registered<br/><br/><small>`PluginController`<br/>`IRenderMvcController`<br/>`UmbracoApiController`</small>
@ulend
@snapend

---?color=#F2EBE6

@title[Composer]

@snap[north text-umb-brown]
@css[text-umb-blue text-bolder](Composers)
@snapend

@snap[south text-umb-dark-blue]
https://www.zpqrtbnk.net/posts/composing-umbraco-v8/
@snapend

@snap[north-west text-umb-brown]
(v7)
@snapend

@snap[north-east text-umb-brown]
(v8)
@snapend

@snap[west span-48]
@code[cs zoom-07](template/src/v7-application-event-handler.cs)
@snapend

@snap[east span-48]
@code[cs zoom-07](template/src/v8-composer.cs)
@snapend

---?color=#F2EBE6

@title[Register Controller]

@snap[north-east text-umb-brown]
@css[text-umb-blue text-bolder](Register custom controller)(v8)
@snapend

@code[cs](template/src/v8-register-controller.cs)

@[5-6](Lifetime is important)
@[8-9](Register a custom service)

---?color=#F2EBE6

@title[Controller changes]

@snap[north text-umb-brown]
@css[text-umb-blue text-bolder](Controller changes)
@snapend

@snap[north-west text-umb-brown]
(v7)
@snapend

@snap[north-east text-umb-brown]
(v8)
@snapend

@snap[west span-48]
@code[cs zoom-08](template/src/v7-controller.cs)
@snapend

@snap[east span-48]
@code[cs zoom-08](template/src/v8-controller.cs)
@snapend

@[4](v7 has RenderModel)
@[13](v8 has ContentModel)

---?color=#F2EBE6

@title[Controller injection]

@snap[north text-umb-brown]
@css[text-umb-blue text-bolder](Controller injection)(v8)
@snapend

@code[cs zoom-09](template/src/v8-controller-injection.cs)

@[3](Inject your custom service)
@[4](There are other dependencies, this are auto-gen'd by VS)
@[6,9](Store it in a field)
@[14](Use your custom service)

---?color=#3544B1

@title[New Features]

@snap[midpoint span-100 text-15]
## New Features!
@snapend
@snap[midpoint span-100]
<br/>
<br/>
<br/>
@css[text-italic text-umb-pink text-08](...maybe some you haven't heard of!)
@snapend