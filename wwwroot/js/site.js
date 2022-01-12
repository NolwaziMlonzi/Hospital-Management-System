var methods =
{
    themes: function (theme) {
        var head = document.getElementsByTagName('head')[0];
        var link = document.createElement('link');
        link.id = "theme";
        link.rel = 'stylesheet';
        link.type = 'text/css';
        link.media = 'all';
        switch (theme) {
            case "slate":
                link.href = "../lib/bootstrap/dist/css/bootstrap_slate.css";
                break;
            case "solar":
                link.href = "../lib/bootstrap/dist/css/bootstrap_solar.css";
                break;
            case "darkly":
                link.href = "../lib/bootstrap/dist/css/bootstrap_darkly.css";
                break;
            case "ocean":
                link.href = "../lib/bootstrap/dist/css/bootstrap_ocean.css";
                break;
            case "cyborg":
                link.href = "../lib/bootstrap/dist/css/bootstrap_cyborg.css";
                break;
            case "default":
            default:
                link.href = "../lib/bootstrap/dist/css/bootstrap.css";

        }

        head.appendChild(link);
    }
}