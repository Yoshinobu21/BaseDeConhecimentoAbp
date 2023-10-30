import { Component, Injector } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import {
  PagedListingComponentBase,
  PagedRequestDto
} from '@shared/paged-listing-component-base';
import {
  ArticleServiceProxy,
  ArticleDto,
  ArticleDtoPagedResultDto
} from '@shared/service-proxies/service-proxies';
import { CreateArticleDialogComponent } from './create-article/create-article-dialog.component';
import { EditArticleDialogComponent } from './edit-article/edit-article-dialog.component';

class PagedArticlesRequestDto extends PagedRequestDto {
  keyword: string;
}

@Component({
  templateUrl: './articles.component.html',
  animations: [appModuleAnimation()]
})
export class ArticlesComponent extends PagedListingComponentBase<ArticleDto> {
  articles: ArticleDto[] = [];
  keyword = '';

  constructor(
    injector: Injector,
    private _articlesService: ArticleServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedArticlesRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    request.keyword = this.keyword;

    this._articlesService
      .getAll(request.keyword, request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ArticleDtoPagedResultDto) => {
        this.articles = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(article: ArticleDto): void {
    abp.message.confirm(
      this.l('ArticleDeleteWarningMessage', article.displayName),
      undefined,
      (result: boolean) => {
        if (result) {
          this._articlesService
            .delete(article.id)
            .pipe(
              finalize(() => {
                abp.notify.success(this.l('SuccessfullyDeleted'));
                this.refresh();
              })
            )
            .subscribe(() => {});
        }
      }
    );
  }

  createArticle(): void {
    this.showCreateOrEditArticleDialog();
  }

  editArticle(article: ArticleDto): void {
    this.showCreateOrEditArticleDialog(article.id);
  }

  showCreateOrEditArticleDialog(id?: number): void {
    let createOrEditArticleDialog: BsModalRef;
    if (!id) {
      createOrEditArticleDialog = this._modalService.show(
        CreateArticleDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditArticleDialog = this._modalService.show(
        EditArticleDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditArticleDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }
}
