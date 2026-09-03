using System.Net.Http;
using VimeoApi.Api;
using VimeoApi.Core;
using VimeoApi.Core.Logging;
using VimeoApi.Core.Models;

namespace VimeoApi;

/// <summary>
/// Build something great. Vimeo's API supports flexible, high-quality video integration with your custom apps.
/// </summary>
public sealed class VimeoApiClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public VimeoApiClient(HttpClient httpClient, VimeoApiClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "VimeoApiClient/3.4.9 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "3.4.9"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "VimeoApiClient");
        _rawClient =
            new RawClient(httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks);
        _auth = new AuthSchemes(options, _server, _rawClient, urlFactory);
    }

    /// <summary>
    /// Use these methods to work with webhooks for API apps.
    /// </summary>
    public ApiAppsWebhooks ApiAppsWebhooks => field ??= new ApiAppsWebhooks(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for retrieving information about the Vimeo API.
    /// </summary>
    public ApiInformationEssentials ApiInformationEssentials =>
        field ??= new ApiInformationEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to perform authentication.
    /// </summary>
    public AuthenticationExtrasAuthenticate AuthenticationExtrasAuthenticate =>
        field ??= new AuthenticationExtrasAuthenticate(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to convert authentication resources.
    /// </summary>
    public AuthenticationExtrasConvert AuthenticationExtrasConvert =>
        field ??= new AuthenticationExtrasConvert(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with authentication.
    /// </summary>
    public AuthenticationExtrasEssentials AuthenticationExtrasEssentials =>
        field ??= new AuthenticationExtrasEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to exchange authentication resources.
    /// </summary>
    public AuthenticationExtrasExchange AuthenticationExtrasExchange =>
        field ??= new AuthenticationExtrasExchange(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with channels in a category.
    /// </summary>
    public CategoriesChannels CategoriesChannels =>
        field ??= new CategoriesChannels(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with categories.
    /// </summary>
    public CategoriesEssentials CategoriesEssentials =>
        field ??= new CategoriesEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with groups in a category.
    /// </summary>
    public CategoriesGroups CategoriesGroups => field ??= new CategoriesGroups(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to manage user interactions with a category.
    /// </summary>
    public CategoriesUsers CategoriesUsers => field ??= new CategoriesUsers(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with videos in a category.
    /// </summary>
    public CategoriesVideos CategoriesVideos => field ??= new CategoriesVideos(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with channel categories.
    /// </summary>
    public ChannelsCategories ChannelsCategories =>
        field ??= new ChannelsCategories(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with channels.
    /// </summary>
    public ChannelsEssentials ChannelsEssentials =>
        field ??= new ChannelsEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with channel moderators.
    /// </summary>
    public ChannelsModerators ChannelsModerators =>
        field ??= new ChannelsModerators(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with private channel members.
    /// </summary>
    public ChannelsPrivateChannelMembers ChannelsPrivateChannelMembers =>
        field ??= new ChannelsPrivateChannelMembers(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with channel subscriptions.
    /// </summary>
    public ChannelsSubscriptionsAndSubscribers ChannelsSubscriptionsAndSubscribers =>
        field ??= new ChannelsSubscriptionsAndSubscribers(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with tags in channels.
    /// </summary>
    public ChannelsTags ChannelsTags => field ??= new ChannelsTags(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with videos in channels.
    /// </summary>
    public ChannelsVideos ChannelsVideos => field ??= new ChannelsVideos(_rawClient, _server, _auth);

    /// <summary>
    /// Vimeo members with access to embed presets can include their own logo images in the embedded player. These custom logos can be part of an embed preset.
    /// <para>
    ///             Use these methods to work with custom logos.
    /// </para>
    /// </summary>
    public EmbedPresetsCustomLogos EmbedPresetsCustomLogos =>
        field ??= new EmbedPresetsCustomLogos(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with embed presets.
    /// </summary>
    public EmbedPresetsEssentials EmbedPresetsEssentials =>
        field ??= new EmbedPresetsEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with folders that have embed presets.
    /// </summary>
    public EmbedPresetsFolders EmbedPresetsFolders =>
        field ??= new EmbedPresetsFolders(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with timeline events.
    /// </summary>
    public EmbedPresetsTimelineEvents EmbedPresetsTimelineEvents =>
        field ??= new EmbedPresetsTimelineEvents(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with videos that have embed presets.
    /// </summary>
    public EmbedPresetsVideos EmbedPresetsVideos =>
        field ??= new EmbedPresetsVideos(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with folders.
    /// </summary>
    public FoldersEssentials FoldersEssentials => field ??= new FoldersEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to manage items in folders.
    /// </summary>
    public FoldersItems FoldersItems => field ??= new FoldersItems(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to manage videos in folders.
    /// </summary>
    public FoldersVideos FoldersVideos => field ??= new FoldersVideos(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with groups.
    /// </summary>
    public GroupsEssentials GroupsEssentials => field ??= new GroupsEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to manage group membership.
    /// </summary>
    public GroupsSubscriptions GroupsSubscriptions =>
        field ??= new GroupsSubscriptions(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to manage group members.
    /// </summary>
    public GroupsUsers GroupsUsers => field ??= new GroupsUsers(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to manage group videos.
    /// </summary>
    public GroupsVideos GroupsVideos => field ??= new GroupsVideos(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with likes.
    /// </summary>
    public LikesEssentials LikesEssentials => field ??= new LikesEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with analytics for events.
    /// </summary>
    public LiveAnalytics LiveAnalytics => field ??= new LiveAnalytics(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with event audio tracks.
    /// </summary>
    public LiveAudioTracks LiveAudioTracks => field ??= new LiveAudioTracks(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with embed privacy for events.
    /// </summary>
    public LiveEmbedPrivacy LiveEmbedPrivacy => field ??= new LiveEmbedPrivacy(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with events.
    /// </summary>
    public LiveEssentials LiveEssentials => field ??= new LiveEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with M3U8 playback URLs for event streams.
    /// </summary>
    public LiveEventM3U8Playback LiveEventM3U8Playback =>
        field ??= new LiveEventM3U8Playback(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with the activation of events.
    /// </summary>
    public LiveEventActivation LiveEventActivation =>
        field ??= new LiveEventActivation(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with the automated closed captions preferences of events.
    /// </summary>
    public LiveEventAutomatedClosedCaptions LiveEventAutomatedClosedCaptions =>
        field ??= new LiveEventAutomatedClosedCaptions(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with event destinations.
    /// </summary>
    public LiveEventDestinations LiveEventDestinations =>
        field ??= new LiveEventDestinations(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with the ending of events.
    /// </summary>
    public LiveEventEnd LiveEventEnd => field ??= new LiveEventEnd(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to manage an event's low-latency option.
    /// </summary>
    public LiveEventLowLatency LiveEventLowLatency =>
        field ??= new LiveEventLowLatency(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with event sessions.
    /// </summary>
    public LiveEventSessions LiveEventSessions => field ??= new LiveEventSessions(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with the thumbnail images of events.
    /// </summary>
    public LiveEventThumbnails LiveEventThumbnails =>
        field ??= new LiveEventThumbnails(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with event videos.
    /// </summary>
    public LiveEventVideos LiveEventVideos => field ??= new LiveEventVideos(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with event media.
    /// </summary>
    public LiveGraphics LiveGraphics => field ??= new LiveGraphics(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with event scenes.
    /// </summary>
    public LiveScenes LiveScenes => field ??= new LiveScenes(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with background images on an On Demand page.
    /// </summary>
    public OnDemandBackgrounds OnDemandBackgrounds =>
        field ??= new OnDemandBackgrounds(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with On Demand pages.
    /// </summary>
    public OnDemandEssentials OnDemandEssentials =>
        field ??= new OnDemandEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with On Demand genres.
    /// </summary>
    public OnDemandGenres OnDemandGenres => field ??= new OnDemandGenres(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with poster images on On Demand pages.
    /// </summary>
    public OnDemandPosters OnDemandPosters => field ??= new OnDemandPosters(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with promotions on On Demand pages.
    /// </summary>
    public OnDemandPromotions OnDemandPromotions =>
        field ??= new OnDemandPromotions(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with purchases and rentals on On Demand pages.
    /// </summary>
    public OnDemandPurchasesAndRentals OnDemandPurchasesAndRentals =>
        field ??= new OnDemandPurchasesAndRentals(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with regions on On Demand pages.
    /// </summary>
    public OnDemandRegions OnDemandRegions => field ??= new OnDemandRegions(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with On Demand seasons.
    /// </summary>
    public OnDemandSeasons OnDemandSeasons => field ??= new OnDemandSeasons(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with videos on On Demand pages.
    /// </summary>
    public OnDemandVideos OnDemandVideos => field ??= new OnDemandVideos(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for making product purchases.
    /// </summary>
    public PaymentsEssentials PaymentsEssentials =>
        field ??= new PaymentsEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with portfolios.
    /// </summary>
    public PortfoliosEssentials PortfoliosEssentials =>
        field ??= new PortfoliosEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to manage portfolio videos.
    /// </summary>
    public PortfoliosVideos PortfoliosVideos => field ??= new PortfoliosVideos(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with federated searches.
    /// </summary>
    public SearchFederated SearchFederated => field ??= new SearchFederated(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to manage custom showcase logos, or the supplementary images, usually logos, that appear on a showcase's page. These images aren't the same as showcase thumbnails, or the images that represent the showcase across Vimeo.
    /// </summary>
    public ShowcasesCustomShowcaseLogos ShowcasesCustomShowcaseLogos =>
        field ??= new ShowcasesCustomShowcaseLogos(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to manage custom thumbnail images for showcases. These thumbnails come from uploaded image files that aren't necessarily stills from a video.
    /// </summary>
    public ShowcasesCustomShowcaseThumbnails ShowcasesCustomShowcaseThumbnails =>
        field ??= new ShowcasesCustomShowcaseThumbnails(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with showcases.
    /// </summary>
    public ShowcasesEssentials ShowcasesEssentials =>
        field ??= new ShowcasesEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to manage showcase videos.
    /// </summary>
    public ShowcasesShowcaseVideos ShowcasesShowcaseVideos =>
        field ??= new ShowcasesShowcaseVideos(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with subscription plans.
    /// </summary>
    public SubscriptionPlansEssentials SubscriptionPlansEssentials =>
        field ??= new SubscriptionPlansEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with tags.
    /// </summary>
    public TagsEssentials TagsEssentials => field ??= new TagsEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with teams.
    /// </summary>
    public TeamsEssentials TeamsEssentials => field ??= new TeamsEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with team members.
    /// </summary>
    public TeamsMembers TeamsMembers => field ??= new TeamsMembers(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with the API tutorial.
    /// </summary>
    public TutorialEssentials TutorialEssentials =>
        field ??= new TutorialEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with the authenticated user's video analytics.
    /// </summary>
    public UsersAnalytics UsersAnalytics => field ??= new UsersAnalytics(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with users.
    /// </summary>
    public UsersEssentials UsersEssentials => field ??= new UsersEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with user feeds.
    /// </summary>
    public UsersFeeds UsersFeeds => field ??= new UsersFeeds(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with user followers.
    /// </summary>
    public UsersFollowers UsersFollowers => field ??= new UsersFollowers(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with learning management systems.
    /// </summary>
    public UsersLms UsersLms => field ??= new UsersLms(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with user pictures.
    /// </summary>
    public UsersPictures UsersPictures => field ??= new UsersPictures(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to search for users.
    /// </summary>
    public UsersSearch UsersSearch => field ??= new UsersSearch(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with a user's watch history.
    /// </summary>
    public UsersWatchHistory UsersWatchHistory => field ??= new UsersWatchHistory(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to access Vimeo's AI-powered video intelligence features, including automatic transcription, subtitle translation, audio dubbing, and video Q&amp;A. All endpoints require the <c>ai</c> OAuth scope and are available exclusively to Enterprise accounts. POST requests are subject to per-endpoint rate limits — contact your account team or Vimeo Sales to increase your allotment. Vimeo AI feature use is subject to <see href="https://vimeo.com/legal/service-terms/ai">Vimeo's AI Addendum</see>.
    /// </summary>
    public VideosAi VideosAi => field ??= new VideosAi(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with animated thumbnails for videos.
    /// </summary>
    public VideosAnimatedThumbnails VideosAnimatedThumbnails =>
        field ??= new VideosAnimatedThumbnails(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with video chapters.
    /// </summary>
    public VideosChapters VideosChapters => field ??= new VideosChapters(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with video content ratings.
    /// </summary>
    public VideosContentRatings VideosContentRatings =>
        field ??= new VideosContentRatings(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with Creative Commons licenses.
    /// </summary>
    public VideosCreativeCommons VideosCreativeCommons =>
        field ??= new VideosCreativeCommons(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with credited users in videos.
    /// </summary>
    public VideosCredits VideosCredits => field ??= new VideosCredits(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to manage the allowlist of embeddable videos.
    /// </summary>
    public VideosEmbedPrivacy VideosEmbedPrivacy =>
        field ??= new VideosEmbedPrivacy(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with videos.
    /// </summary>
    public VideosEssentials VideosEssentials => field ??= new VideosEssentials(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with the video fragments for branched or segmented scrubbers.
    /// </summary>
    public VideosFragments VideosFragments => field ??= new VideosFragments(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with video languages.
    /// </summary>
    public VideosLanguages VideosLanguages => field ??= new VideosLanguages(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with M3U8 playback URLs for event streams.
    /// </summary>
    public VideosLiveM3U8Playback VideosLiveM3U8Playback =>
        field ??= new VideosLiveM3U8Playback(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to moderate videos.
    /// </summary>
    public VideosModeration VideosModeration => field ??= new VideosModeration(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with nondestructive trimming.
    /// </summary>
    public VideosNondestructiveTrimming VideosNondestructiveTrimming =>
        field ??= new VideosNondestructiveTrimming(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with recommended videos.
    /// </summary>
    public VideosRecommendations VideosRecommendations =>
        field ??= new VideosRecommendations(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with showcase videos.
    /// </summary>
    public VideosShowcases VideosShowcases => field ??= new VideosShowcases(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with associated tags.
    /// </summary>
    public VideosTags VideosTags => field ??= new VideosTags(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with video text tracks.
    /// </summary>
    public VideosTextTracks VideosTextTracks => field ??= new VideosTextTracks(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with video thumbnails.
    /// </summary>
    public VideosThumbnails VideosThumbnails => field ??= new VideosThumbnails(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with video transcripts.
    /// </summary>
    public VideosTranscripts VideosTranscripts => field ??= new VideosTranscripts(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with unlisted videos.
    /// </summary>
    public VideosUnlistedVideos VideosUnlistedVideos =>
        field ??= new VideosUnlistedVideos(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with video uploads.
    /// </summary>
    public VideosUploads VideosUploads => field ??= new VideosUploads(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with video versioning.
    /// </summary>
    public VideosVersions VideosVersions => field ??= new VideosVersions(_rawClient, _server, _auth);

    /// <summary>
    /// Use these methods to work with video comments.
    /// </summary>
    public VideosVideoComments VideosVideoComments =>
        field ??= new VideosVideoComments(_rawClient, _server, _auth);

    /// <summary>
    /// These are the most common methods for working with a user's Watch Later queue.
    /// </summary>
    public WatchLaterQueueEssentials WatchLaterQueueEssentials =>
        field ??= new WatchLaterQueueEssentials(_rawClient, _server, _auth);
}
