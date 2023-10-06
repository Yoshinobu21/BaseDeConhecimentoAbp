import { BaseDeConhecimentoTemplatePage } from './app.po';

describe('BaseDeConhecimento App', function() {
  let page: BaseDeConhecimentoTemplatePage;

  beforeEach(() => {
    page = new BaseDeConhecimentoTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
