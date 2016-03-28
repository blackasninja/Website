
var _settings = {

    // Fullscreen
    useFullScreen: true,

    // Section Transitions
    useSectionTransitions: true,

    // Fade in speed (in ms)
    fadeInSpeed: 1000,

    // skel
    skel: {
        prefix: 'css/style',
        resetCSS: true,
        useOrientation: true,
        boxModel: 'border',
        breakpoints: {
            'max': { range: '*', containers: 1440, hasStyleSheet: false },
            'wide': { range: '-1920', containers: 1360 },
            'normal': { range: '-1680', containers: 1200 },
            'narrow': { range: '-1280', containers: 960 },
            'narrower': { range: '-1000', containers: '95%', lockViewport: true },
            'mobile': { range: '-640', containers: '95%', grid: { gutters: 20 }, lockViewport: true },
            'mobile-narrow': { range: '-480', containers: '95%', grid: { collapse: true, gutters: 10 }, lockViewport: true, hasStyleSheet: false }
        }
    },

    // poptrox
    poptrox: {
        baseZIndex: 10001,
        useBodyOverflow: false,
        usePopupEasyClose: false,
        overlayColor: '#1f2328',
        overlayOpacity: 0.65,
        usePopupDefaultStyling: false,
        usePopupCaption: true,
        popupLoaderText: '',
        windowMargin: 50,
        usePopupNav: true
    }

};


$(function () {
    //particles();
    $('[data-toggle="tooltip"]').tooltip();
    $('.gallery').poptrox(_settings.poptrox);
});