import { Theme, WithStyles, withStyles } from '@material-ui/core/styles';
import * as React from 'react';

interface FooterProps {
  version: string;
  title: string;
}

const styles = (theme: Theme) => ({
  footer: {
    padding: 20,
    textAlign: 'center'
  }
});

class FooterView extends React.Component<FooterProps & WithStyles<'footer'>, {}> {

  public render() {
    const year = new Date().getFullYear();
    const { classes, title, version } = this.props;
    return (
      <div className={classes.footer}>
        <div>
          {title} © {year} {version}
        </div>
      </div>
    );
  }
}

export default withStyles(styles as any)<FooterProps>(FooterView);
