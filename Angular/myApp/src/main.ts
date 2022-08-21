import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { environment } from './environments/environment';

if (environment.production) {
  enableProdMode();
}
// App Module tell how we will start which will be the start component 
// main --> app.module.ts --> find the start component with bootstraping
platformBrowserDynamic().bootstrapModule(AppModule)
  .catch(err => console.error(err));
