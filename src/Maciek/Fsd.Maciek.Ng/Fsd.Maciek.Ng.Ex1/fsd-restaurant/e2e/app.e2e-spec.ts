import { FsdRestaurantPage } from './app.po';

describe('fsd-restaurant App', () => {
  let page: FsdRestaurantPage;

  beforeEach(() => {
    page = new FsdRestaurantPage();
  });

  it('should display welcome message', done => {
    page.navigateTo();
    page.getParagraphText()
      .then(msg => expect(msg).toEqual('Welcome to app!!'))
      .then(done, done.fail);
  });
});
