import { FsdAppPage } from './app.po';

describe('fsd-app App', () => {
  let page: FsdAppPage;

  beforeEach(() => {
    page = new FsdAppPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
